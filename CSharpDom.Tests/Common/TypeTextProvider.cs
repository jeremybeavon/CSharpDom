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
            string typeName = type.Name();
            string[] namespaces = type.Namespace.Split('.').Skip(2).Select(RemovePlural).ToArray();
            foreach (string @namespace in namespaces)
            {
                typeName = typeName.Replace(@namespace + "With", string.Empty);
            }

            typeName = typeName.Replace(namespaces.Last(), string.Empty);
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
