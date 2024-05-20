using Frigg.Common;
using Frigg.CTC.Logic;
using Frigg.Devices.SDR;
using Frigg.Model;
using Microsoft.Extensions.DependencyInjection;

namespace WinFrigg
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            _ = services.Scan(scan => scan
                .FromAssemblies(AppDomain.CurrentDomain.GetAssemblies())
                .AddClasses(classes => classes.AssignableTo<ISDRDeviceManager>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            _ = services.AddTransient<App>();
            _ = services.AddTransient<Splash>();

            CTCStepFactoryDictionary stepFactories = [];
            IEnumerable<Type> stepTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsSubclassOf(typeof(CTCStep)) && !t.IsAbstract);

            foreach (Type type in stepTypes)
            {
                CTCStep constructor()
                {
                    return (CTCStep?)Activator.CreateInstance(type) ?? throw new Exception("Failed to create CTCStep");
                }

                CTCStep tempStep = (CTCStep?)Activator.CreateInstance(type) ?? throw new Exception($"Type of CTC does not exist ({type})");
                if (tempStep != null)
                {
                    stepFactories.Add(tempStep.StepName, (constructor, tempStep.StepOrder));
                }
            }
            _ = services.AddSingleton(stepFactories);

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            ServiceActivator.Configure(serviceProvider);

            foreach (ServiceDescriptor service in services)
            {
                if (service.Lifetime == ServiceLifetime.Singleton)
                {
                    _ = serviceProvider.GetService(service.ServiceType);
                }
            }
        }
    }
}