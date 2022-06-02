using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

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
                Text = "test",
                Icon = System.Drawing.SystemIcons.Application,
                ContextMenuStrip = contextMenu
            };

            //notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(NotifyIcon_Click);

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
            Application.Current.Shutdown();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        } 
    }   
}
