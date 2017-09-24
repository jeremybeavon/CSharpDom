using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal class MemberListSyntax<TSyntax>
    {
        public MemberListSyntax(string key, IEnumerable<TSyntax> syntax)
        {
            Key = key;
            Syntax = syntax;
        }

        public string Key { get; private set; }

        public IEnumerable<TSyntax> Syntax { get; private set; }
    }
}
