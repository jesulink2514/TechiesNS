using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: XmlnsDefinition("http://somostechies.com/techies", "Techies.Common.XF.Controls")]
[assembly: XmlnsDefinition("http://somostechies.com/techies", "Techies.Common.XF.Converters")]

namespace Techies.Common.XF
{
    public static class PreserveLinker
    {
        public static void Preserve()
        {
        }
    }
}
