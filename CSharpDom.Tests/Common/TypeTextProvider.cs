using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Common
{
    public static class TypeTextProvider
    {
        public static string GetTypeText(Type type)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetResourceName(type)))
            {
                using (TextReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd().Trim();
                }
            }
        }

        private static string GetResourceName(Type type)
        {
            return "CSharpDom.Tests.ExpectedResults." + type.Namespace + "." + type.Name + ".cs";
        }
    }
}
