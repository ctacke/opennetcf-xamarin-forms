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
                return Size;
            }

            var scaled = s_layoutService.GetScaledInt32(Size);

            System.Diagnostics.Debug.WriteLine(string.Format("Scaled size {0} => {1}", Size, scaled));

            return (int)scaled;
        }
    }
}
