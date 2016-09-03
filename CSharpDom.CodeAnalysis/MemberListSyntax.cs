using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class MemberListSyntax
    {
        public MemberListSyntax(string key, IEnumerable<MemberDeclarationSyntax> syntax)
        {
            Key = key;
            Syntax = syntax;
        }

        public string Key { get; private set; }

        public IEnumerable<MemberDeclarationSyntax> Syntax { get; private set; }
    }
}
