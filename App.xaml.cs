using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PechicoDesktop.Models;

namespace PechicoDesktop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var contextMenu = new System.Windows.Forms.ContextMenuStrip();
            contextMenu.Items.Add("Application Setting", null, ApplicationSettiong_Click);
            contextMenu.Items.Add("Quit PechicoDesktop", null, Exit_Click);
            
            var notifyIcon = new System.Windows.Forms.NotifyIcon
            {
                Visible = true,
                Text = "PechicoDesktop",
                Icon = System.Drawing.SystemIcons.Application,
                ContextMenuStrip = contextMenu
            };

            notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(NotifyIcon_Click);
        }

        private void NotifyIcon_Click(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                new PechicoDesktop.MainWindow().Show();
            }
        }

        private void ApplicationSettiong_Click(object sender, EventArgs e)
        {
            var viewModel = new NotificationViewModel()
            {
                Id = 111,
                CompanyName = "株式会社テスト",
                TelephoneNumber = "0822-45-3333",
                InquiryAt = DateTime.Today
            };
            var notification = new Notifications(viewModel);
            notification.ShowToast();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Notifications.Clear();
            Application.Current.Shutdown();
        } 
    }   
}
