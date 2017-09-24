using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class MemberListSyntax : MemberListSyntax<MemberDeclarationSyntax>
    {
        public MemberListSyntax(string key, IEnumerable<MemberDeclarationSyntax> syntax)
            : base(key, syntax)
        {
        }
    }
}
