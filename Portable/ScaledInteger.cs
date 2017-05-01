using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenNETCF
{
    public class ScaledInteger : IMarkupExtension
    {
        private static ILayoutService s_layoutService = OpenNETCF.IoC.RootWorkItem.Services.Get<ILayoutService>();

        public int Size { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (s_layoutService == null)
            {
                System.Diagnostics.Debug.WriteLine("ScaledInteger has no ILayoutService!");

                return Size;
            }

            var scaled = s_layoutService.GetScaledInt32(Size);

            return (int)scaled;
        }
    }
}
