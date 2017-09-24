using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal interface IMemberList : IMemberList<MemberDeclarationSyntax>
    {
        void CombineList(params MemberListSyntax[] syntax);
    }
}
