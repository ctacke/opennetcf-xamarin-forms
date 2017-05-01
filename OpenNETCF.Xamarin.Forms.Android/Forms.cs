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
using OpenNETCF.IoC;
using OpenNETCF.Platform.Droid;

namespace OpenNETCF
{
    public static class Forms
    {
        public static void Init()
        {
            // add the type to the DI container - an instance will be created only if it's ever used
            RootWorkItem.Services.AddOnDemand<AndroidLayoutService, ILayoutService>();
        }
    }
}