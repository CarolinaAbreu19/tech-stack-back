using System;

namespace TechStackBack.Util
{
    public static class ManipularData
    {
        public static string ConverterToString(DateTime data) {
        
            return data.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static string ConverterToStringSemHora(DateTime data) {
            return data.ToString("dd/MM/yyyy");
        }
    }
}
