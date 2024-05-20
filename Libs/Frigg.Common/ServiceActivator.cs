using Microsoft.Extensions.DependencyInjection;

namespace Frigg.Common
{
    // Static scope provider
    public static class ServiceActivator
    {
        private static IServiceProvider? serviceProvider = default!;

        public static void Configure(IServiceProvider serviceProvider)
        {
            ServiceActivator.serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public static T? GetService<T>()
        {
            try
            {
#pragma warning disable CS8714 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match 'notnull' constraint.
                return serviceProvider == null ? default : serviceProvider.GetRequiredService<T>() ?? default;
#pragma warning restore CS8714 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match 'notnull' constraint.
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}