using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CSharpDom.CodeAnalysis
{
    public static class MemberInfoExtensions
    {
        private static readonly Regex memberNameRegex = new Regex(@"^(?:[^\.]+[\.\+])*(?<Name>\w+)(?:`\d+)?$", RegexOptions.Compiled);

        public static string Name(this MemberInfo member)
        {
            return memberNameRegex.Replace(member.Name, "${Name}");
        }
    }
}
