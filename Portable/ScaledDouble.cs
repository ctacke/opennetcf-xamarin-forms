using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace OpenNETCF
{
    public sealed class ScaledDouble : IMarkupExtension
    {
        private static ILayoutService s_layoutService = OpenNETCF.IoC.RootWorkItem.Services.Get<ILayoutService>();

        public double FontSize { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (s_layoutService == null)
            {
                System.Diagnostics.Debug.WriteLine("ScaledDouble has no ILayoutService!");

                return FontSize;
            }

            var scaled = s_layoutService.GetScaledDouble(FontSize);

            return scaled;
        }
    }
}
