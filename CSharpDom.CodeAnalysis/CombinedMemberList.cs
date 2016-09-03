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
    internal sealed class CombinedMemberList<TParentNode, TParentSyntax> : IEnumerable
        where TParentSyntax : class
    {
        private readonly Node<TParentNode, TParentSyntax> node;
        private readonly Func<TParentSyntax, SyntaxList<MemberDeclarationSyntax>, TParentSyntax> createList;
        private readonly List<KeyValuePair<string, Func<IEnumerable<MemberDeclarationSyntax>>>> list;

        public CombinedMemberList(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<MemberDeclarationSyntax>, TParentSyntax> createList)
        {
            this.node = node;
            this.createList = createList;
        }

        public void Add(string key, Func<IEnumerable<MemberDeclarationSyntax>> syntax)
        {
            list.Add(new KeyValuePair<string, Func<IEnumerable<MemberDeclarationSyntax>>>(key, syntax));
        }

        public void CombineList(string key, IEnumerable<MemberDeclarationSyntax> syntax)
        {
            CombineList(entry => entry.Key == key ? syntax : entry.Value());
        }

        public void CombineList(params MemberListSyntax[] syntax)
        {
            IDictionary<string, IEnumerable<MemberDeclarationSyntax>> syntaxDictionary =
                syntax.ToDictionary(entry => entry.Key, entry => entry.Syntax);
            CombineList(entry => GetSyntax(entry, syntaxDictionary));
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        private IEnumerable<MemberDeclarationSyntax> GetSyntax(
            KeyValuePair<string, Func<IEnumerable<MemberDeclarationSyntax>>> entry,
            IDictionary<string, IEnumerable<MemberDeclarationSyntax>> syntaxDictionary)
        {
            IEnumerable<MemberDeclarationSyntax> syntax;
            return syntaxDictionary.TryGetValue(entry.Key, out syntax) ? syntax : entry.Value();
        }

        private void CombineList(
            Func<KeyValuePair<string, Func<IEnumerable<MemberDeclarationSyntax>>>, IEnumerable<MemberDeclarationSyntax>> selectFunc)
        {
            node.Syntax = createList(node.Syntax, SyntaxFactory.List(list.SelectMany(selectFunc)));
        }
    }
}
