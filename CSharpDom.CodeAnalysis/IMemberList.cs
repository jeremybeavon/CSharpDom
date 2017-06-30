using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal interface IMemberList
    {
        void CombineList(string key, IEnumerable<MemberDeclarationSyntax> syntax);

        void CombineList(params MemberListSyntax[] syntax);
    }
}
