namespace Frigg.CTC.Logic
{
    public static class ZigBeeWiFiOverlapFrequencyDictionary
    {
        public static Dictionary<string, (int ZigBeeChannel, double ZigBeeFrequency, int WiFiChannel, double WiFiFrequency)> KeyValuePairs => new()
        {
            {"WiFi Channel 1 - ZigBee Channel 12",  (12, 2410, 1, 2412)},
            {"WiFi Channel 1 - ZigBee Channel 13",  (13, 2415, 1, 2412)},
            {"WiFi Channel 1 - ZigBee Channel 11",  (11, 2405, 1, 2412)},
            {"WiFi Channel 6 - ZigBee Channel 17",  (17, 2435, 6, 2437)},
            {"WiFi Channel 6 - ZigBee Channel 18",  (18, 2440, 6, 2437)},
            {"WiFi Channel 6 - ZigBee Channel 16",  (16, 2430, 6, 2437)},
            {"WiFi Channel 11 - ZigBee Channel 22", (22, 2460, 11, 2462)},
            {"WiFi Channel 11 - ZigBee Channel 23", (23, 2465, 11, 2462)},
            {"WiFi Channel 11 - ZigBee Channel 21", (21, 2455, 11, 2462)}
        };
    }
}