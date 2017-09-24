using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal interface IMemberList<TSyntax>
    {
        void CombineList(string key, IEnumerable<TSyntax> syntax);

        void CombineList(params MemberListSyntax<TSyntax>[] syntax);

        void InsertBefore(string key, string newKey, Func<IEnumerable<TSyntax>> syntax);

        void InsertAfter(string key, string newKey, Func<IEnumerable<TSyntax>> syntax);

        void Replace(string key, Func<IEnumerable<TSyntax>> syntax);
    }
}
