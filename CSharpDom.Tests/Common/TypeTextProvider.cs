using System;
using System.IO;
using System.Linq;
using CSharpDom.Reflection;
using CSharpDom.Tests.ExpectedResults;

namespace CSharpDom.Tests.Common
{
    public static class TypeTextProvider
    {
        public static string GetTypeText(Type type)
        {
            string resourceName = GetResourceName(type);
            using (Stream stream = typeof(ExpectedResultsType).Assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new ArgumentException("Resource not found for: " + resourceName, nameof(type));
                }

                using (TextReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd().Trim();
                }
            }
        }

        private static string GetResourceName(Type type)
        {
            string typeName = type.Name();
            string[] namespaces = type.Namespace.Split('.').Skip(2).Select(RemovePlural).Reverse().ToArray();
            foreach (string @namespace in namespaces)
            {
                typeName = typeName.Replace(@namespace + "With", string.Empty);
            }

            if (!typeName.EndsWith("BaseClass"))
            {
                string lastNamespace = namespaces[0];
                typeName = typeName
                    .Replace(lastNamespace + "s", string.Empty)
                    .Replace(lastNamespace, string.Empty);
            }

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
