using System;
using System.IO;
using System.Linq;
using System.Reflection;
using CSharpDom.Reflection;

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
            string typeNamePrefix = string.Join("With", type.Namespace.Split('.').Skip(2).Select(RemovePlural)) + "With";
            string typeName = type.Name().Replace(typeNamePrefix, string.Empty);
            return string.Format(
                "CSharpDom.Tests.ExpectedResults.{0}.{1}.cs",
                type.Namespace,
                string.IsNullOrWhiteSpace(typeName) ? "Default" : typeName);
                
        }

        private static string RemovePlural(string name)
        {
            return name.TrimEnd('s').Replace("Classe", "Class").Replace("Propertie", "Property");
        }
    }
}
