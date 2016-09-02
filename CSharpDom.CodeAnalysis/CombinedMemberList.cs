using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class CombinedMemberList : IEnumerable
    {
        private readonly Action<SyntaxList<MemberDeclarationSyntax>> createList;
        private readonly List<KeyValuePair<string, Func<IEnumerable<MemberDeclarationSyntax>>>> list;

        public CombinedMemberList(Action<SyntaxList<MemberDeclarationSyntax>> createList)
        {
            this.createList = createList;
        }

        public void Add(string key, Func<IEnumerable<MemberDeclarationSyntax>> syntax)
        {
            list.Add(new KeyValuePair<string, Func<IEnumerable<MemberDeclarationSyntax>>>(key, syntax));
        }

        public void CombineList(string key, IEnumerable<MemberDeclarationSyntax> syntax)
        {
            createList(SyntaxFactory.List(list.SelectMany(entry => entry.Key == key ? syntax : entry.Value())));
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
