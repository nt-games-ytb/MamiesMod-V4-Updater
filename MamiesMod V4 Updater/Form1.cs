#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion
using MamiesMod_V4_Updater;
using MetroFramework;
using MetroFramework.Forms;

namespace MamiesMod_V4_Updater
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Private
        WebClient client = new WebClient();
        WebClient client1 = new WebClient();
        WebClient client2 = new WebClient();
        WebClient client3 = new WebClient();
        WebClient client4 = new WebClient();
        WebClient client5 = new WebClient();
        WebClient client6 = new WebClient();
        WebClient client7 = new WebClient();
        int fileNumber;
        string site = "http://nt-games-site.000webhostapp.com/img/MamiesMod%20V4/";
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            try
            {
                versionText.Text = "Version : " + webClient.DownloadString("https://pastebin.com/raw/BMqeJ1b1");
                Show();
                Thread.Sleep(5000);
                update();
            }
            catch
            {
                MessageBox.Show("You are not connected to internet or the MamiesMod site is down !", "MamiesMod V4 Updater");
                Close();
            }
        }

        private void update()
        {
            #region Test
            /*if (fileNumber == 0)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadProgressChanged += progressBarNumber;
                webClient.DownloadFileCompleted += downloadFileCompleted;
                Uri uri = new Uri("https://nt-games-site.000webhostapp.com/img/update/es/MamiesMod%20V2.resources.dll");
                webClient.DownloadFileAsync(uri, "en/MamiesMod V4.resources.dll");
                downloadName.Text = "Download : MamiesMod V4 English langage";
            }
            if (fileNumber == 2)
            {
                WebClient webClient = new WebClient();
                webClient.DownloadProgressChanged += progressBarNumber;
                webClient.DownloadFileCompleted += downloadFileCompleted;
                Uri uri = new Uri(site + "https://nt-games-site.000webhostapp.com/img/update/es/MamiesMod%20V2.resources.dll");
                webClient.DownloadFileAsync(uri, "fr/MamiesMod V4.resources.dll");
                downloadName.Text = "Download : MamiesMod V4 French langage";
            }
            
                /*if (fileNumber == 2)
                {
                    Uri uri = new Uri(site + "ja/MamiesMod%20V4.resources.dll");
                    webClient.DownloadFileAsync(uri, "ja/MamiesMod V4.resources.dll");
                    downloadName.Text = "Download : MamiesMod V4 Japnese langage";
                }
                if (fileNumber == 3)
                {
                    Uri uri = new Uri(site + "de/MamiesMod%20V4.resources.dll");
                    webClient.DownloadFileAsync(uri, "de/MamiesMod V4.resources.dll");
                    downloadName.Text = "Download : MamiesMod V4 German langage";
                }
                if (fileNumber == 4)
                {
                    Uri uri = new Uri(site + "es/MamiesMod%20V4.resources.dll");
                    webClient.DownloadFileAsync(uri, "es/MamiesMod V4.resources.dll");
                    downloadName.Text = "Download : MamiesMod V4 Spanish langage";
                }
                if (fileNumber == 5)
                {
                    Uri uri = new Uri(site + "it/MamiesMod%20V4.resources.dll");
                    webClient.DownloadFileAsync(uri, "it/MamiesMod V4.resources.dll");
                    downloadName.Text = "Download : MamiesMod V4 Italian langage";
                }*/

            /*if (fileNumber == 1)
            {
                WebClient webClient1 = new WebClient();
                webClient1.DownloadProgressChanged += progressBarNumber;
                webClient1.DownloadFileCompleted += downloadFileCompleted;
                Uri uri = new Uri(site + "MamiesMod%20V4.exe");
                webClient1.DownloadFileAsync(uri, "MamiesMod V4.exe");
                downloadName.Text = "Download : MamiesMod V4";
            }

            if (fileNumber == 7)
            {
                MessageBox.Show("MamiesMod V4 is updated !", "MamiesMod V4 Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }*/
            #endregion

            client.DownloadProgressChanged += progressBarNumber;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;

            client1.DownloadProgressChanged += progressBarNumber;
            client1.DownloadFileCompleted += Client_DownloadFileCompleted1;

            client2.DownloadProgressChanged += progressBarNumber;
            client2.DownloadFileCompleted += Client_DownloadFileCompleted2;

            client3.DownloadProgressChanged += progressBarNumber;
            client3.DownloadFileCompleted += Client_DownloadFileCompleted3;

            client4.DownloadProgressChanged += progressBarNumber;
            client4.DownloadFileCompleted += Client_DownloadFileCompleted4;

            client5.DownloadProgressChanged += progressBarNumber;
            client5.DownloadFileCompleted += Client_DownloadFileCompleted5;

            client6.DownloadProgressChanged += progressBarNumber;
            client6.DownloadFileCompleted += Client_DownloadFileCompleted6;

            Uri uri = new Uri(site + "en/MamiesMod%20V4.resources.dll");
            client.DownloadFileAsync(uri, "en/MamiesMod V4.resources.dll");
            downloadName.Text = "Download : MamiesMod V4 English langage";
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Uri uri = new Uri(site + "fr/MamiesMod%20V4.resources.dll");
            client1.DownloadFileAsync(uri, "fr/MamiesMod V4.resources.dll");
            downloadName.Text = "Download : MamiesMod V4 French langage";
        }

        private void Client_DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            Uri uri = new Uri(site + "ja/MamiesMod%20V4.resources.dll");
            client2.DownloadFileAsync(uri, "ja/MamiesMod V4.resources.dll");
            downloadName.Text = "Download : MamiesMod V4 Japnese langage";
        }

        private void Client_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            Uri uri = new Uri(site + "de/MamiesMod%20V4.resources.dll");
            client3.DownloadFileAsync(uri, "de/MamiesMod V4.resources.dll");
            downloadName.Text = "Download : MamiesMod V4 German langage";
        }

        private void Client_DownloadFileCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            Uri uri = new Uri(site + "es/MamiesMod%20V4.resources.dll");
            client4.DownloadFileAsync(uri, "es/MamiesMod V4.resources.dll");
            downloadName.Text = "Download : MamiesMod V4 Spanish langage";
        }

        private void Client_DownloadFileCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            Uri uri = new Uri(site + "it/MamiesMod%20V4.resources.dll");
            client5.DownloadFileAsync(uri, "it/MamiesMod V4.resources.dll");
            downloadName.Text = "Download : MamiesMod V4 Italian langage";
        }

        private void Client_DownloadFileCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            Uri uri = new Uri(site + "MamiesMod%20V4.exe");
            client6.DownloadFileAsync(uri, "MamiesMod V4.exe");
            downloadName.Text = "Download : MamiesMod V4";
        }

        private void Client_DownloadFileCompleted6(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("MamiesMod V4 is updated !", "MamiesMod V4 Updater", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void progressBarNumber(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                downloadBar.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                downloadText.Text = $"Download : {string.Format("{0:0.##}", percentage)}%";
                downloadBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }

        private void downloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            fileNumber = fileNumber + 1;
            update();
        }
    }
}
