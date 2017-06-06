using System;
using System.Globalization;

namespace ReportLocalization
{
    public static class LocalizedValue
    {
        public static string GetString(string name, string cultureInfoName)
        {
            string returnString = string.Empty;
            try
            {
                // Culture formation  
                CultureInfo ci = new CultureInfo(cultureInfoName);
                // Value retrieved from the resource file  
                returnString = (cultureInfoName == "hi-IN") ? Hindi.ResourceManager.GetString(name, ci) : English.ResourceManager.GetString(name, ci);
            }
            catch (Exception ex) { }
            if (string.IsNullOrEmpty(returnString))
            {
                returnString = name;
            }
            return returnString;
        }
    }
}
