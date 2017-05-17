using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenNETCF
{
    public interface ILayoutService
    {
        double GetScaledDouble(double original);
        int GetScaledInt32(int original);
    }
}
