using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text.RegularExpressions;

namespace CSharpDom.CodeAnalysis
{
    public static class MemberReferenceExtensions
    {
        private static readonly Regex memberNameRegex = new Regex(@"^(?:[^\.]+[\.\+])*(?<Name>\w+)(?:`\d+)?$", RegexOptions.Compiled);

        public static string Name(this MemberReference member)
        {
            return memberNameRegex.Replace(member.Name, "${Name}");
        }
    }
}
