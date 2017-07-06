using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ProjectMemberList : IMemberList
    {
        public static readonly IMemberList Instance = new ProjectMemberList();

        public void CombineList(string key, IEnumerable<MemberDeclarationSyntax> syntax)
        {
            throw new NotSupportedException();
        }

        public void CombineList(params MemberListSyntax[] syntax)
        {
            throw new NotSupportedException();
        }
    }
}
