using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;

namespace PechicoDesktop.Models
{
    class Notifications
    {
        private ToastContentBuilder toastContentBuilder;

        public Notifications(NotificationViewModel notificationViewModel)
        {
            this.toastContentBuilder = new ToastContentBuilder()
                .AddArgument("conversionId", notificationViewModel.Id)
                .AddToastActivationInfo("test", ToastActivationType.Foreground)
                .AddText(notificationViewModel.CompanyName, hintMaxLines: 1)
                .AddText(notificationViewModel.TelephoneNumber)
                .AddButton(
                    new ToastButton()
                    .SetContent("See more details")
                    .AddArgument("action", "viewDetails")
                );
        }

        public void ShowToast()
        {
            toastContentBuilder.Show();
        }

        public static void Clear()
        {
            ToastNotificationManagerCompat.History.Clear();
        }
    }
}
