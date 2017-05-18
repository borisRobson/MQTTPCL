using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using MQTTPCL.Droid;
using MQTTPCL;

[assembly: Dependency(typeof(Notifier_Android))]

namespace MQTTPCL.Droid
{
    class Notifier_Android : Java.Lang.Object, INotifier
    {
        Context ctx = Android.App.Application.Context.ApplicationContext;

        public void Notify(MQTTMessage msg)
        {
            //Set up an intent so that tapping the notification returns to this app
            Intent intent = new Intent(ctx, typeof(MainActivity));

            //Create a PendingIntent;
            const int pendingIntentId = 0;
            PendingIntent pendingIntent =
                PendingIntent.GetActivity(ctx, pendingIntentId, intent, PendingIntentFlags.OneShot);

            //Instantiate the builder and set notification elements, including Pending Intent
            Notification.Builder builder = new Notification.Builder(ctx)
                .SetContentIntent(pendingIntent)
                .SetContentTitle(msg.Topic)
                .SetContentText(msg.Payload)
                .SetSmallIcon(Resource.Drawable.ic_stat_button_click);

            //Build the notification
            Notification notification = builder.Build();

            //Get the notification manager
            NotificationManager notificationManager =
                ctx.GetSystemService(Context.NotificationService) as NotificationManager;

            //Publish the notification
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);
        }
    }
}