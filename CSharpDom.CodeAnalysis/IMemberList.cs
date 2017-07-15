using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal interface IMemberList
    {
        void CombineList(string key, IEnumerable<MemberDeclarationSyntax> syntax);

        void CombineList(params MemberListSyntax[] syntax);

        void InsertBefore(string key, string newKey, Func<IEnumerable<MemberDeclarationSyntax>> syntax);

        void InsertAfter(string key, string newKey, Func<IEnumerable<MemberDeclarationSyntax>> syntax);

        void Replace(string key, Func<IEnumerable<MemberDeclarationSyntax>> syntax);
    }
}
