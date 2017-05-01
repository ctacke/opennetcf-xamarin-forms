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
                return FontSize;
            }

            var scaled = s_layoutService.GetScaledDouble(FontSize);

            System.Diagnostics.Debug.WriteLine(string.Format("Scaled font {0} => {1}", FontSize, scaled));

            return scaled;
        }
    }
}
