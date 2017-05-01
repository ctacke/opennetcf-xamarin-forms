using Xamarin.Forms;

namespace OpenNETCF.Platform.Droid
{
    public sealed class AndroidLayoutService : ILayoutService
    {
        private static double s_standardWidthInches = 3.75;
        private static double s_widthScaleFactor = (double)Android.App.Application.Context.Resources.DisplayMetrics.WidthPixels / (double)Android.App.Application.Context.Resources.DisplayMetrics.DensityDpi / s_standardWidthInches;

        public AndroidLayoutService()
        {
        }

        public double GetScaledDouble(double fontSize)
        {
            return fontSize * s_widthScaleFactor;
        }

        public int GetScaledInt32(int original)
        {
            return (int)(GetScaledDouble(original));
        }
    }
}
