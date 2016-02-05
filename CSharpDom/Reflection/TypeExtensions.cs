using System;
using System.Text.RegularExpressions;

namespace CSharpDom.Reflection
{
    public static class TypeExtensions
    {
        private static readonly Regex typeNameRegex = new Regex(@"^(?:[^\.]+\.)*(?<Name>\w+)(?:`\d+)?$", RegexOptions.Compiled);

        public static string Name(this Type type)
        {
            return typeNameRegex.Replace(type.Name, "${Name}");
        }
    }
}
