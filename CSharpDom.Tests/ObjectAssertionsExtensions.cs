using FluentAssertions.Primitives;
using System;
using System.IO;
using System.Reflection;

namespace CSharpDom.Tests
{
    public static class ObjectAssertionsExtensions
    {
        public static void HaveTextEqualTo(this ObjectAssertions assertions, Type type)
        {
        }

        private static string GetTypeText(Type type)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetResourceName(type)))
            {
                using (TextReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private static string GetResourceName(Type type)
        {
            return "CSharpDom.Tests.ExpectedResults." + type.Namespace + "." + type.Name + ".cs";
        }
    }
}
