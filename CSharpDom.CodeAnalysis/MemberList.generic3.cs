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
    internal class MemberList<TParent, TParentSyntax, TChildSyntax> :
        IEnumerable,
        IMemberList<TChildSyntax>
        where TParentSyntax : class
        where TChildSyntax : SyntaxNode
    {
        private readonly Node<TParent, TParentSyntax> node;
        private readonly Func<TParentSyntax, IEnumerable<TChildSyntax>, TParentSyntax> createList;
        private readonly List<KeyValuePair<string, Func<IEnumerable<TChildSyntax>>>> list;

        public MemberList(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, IEnumerable<TChildSyntax>, TParentSyntax> createList)
        {
            this.node = node;
            this.createList = createList;
            list = new List<KeyValuePair<string, Func<IEnumerable<TChildSyntax>>>>();
        }
        
        public void Add(string key, Func<IEnumerable<TChildSyntax>> syntax)
        {
            list.Add(new KeyValuePair<string, Func<IEnumerable<TChildSyntax>>>(key, syntax));
        }

        public void CombineList(string key, IEnumerable<TChildSyntax> syntax)
        {
            CombineList(entry => entry.Key == key ? syntax : entry.Value());
        }

        public void CombineList(IEnumerable<MemberListSyntax<TChildSyntax>> syntax)
        {
            IDictionary<string, IEnumerable<TChildSyntax>> syntaxDictionary =
                syntax.ToDictionary(entry => entry.Key, entry => entry.Syntax);
            CombineList(entry => GetSyntax(entry, syntaxDictionary));
        }

        public void CombineList(params MemberListSyntax<TChildSyntax>[] syntax)
        {
            CombineList((IEnumerable<MemberListSyntax<TChildSyntax>>)syntax);
        }

        public void Replace(string key, Func<IEnumerable<TChildSyntax>> syntax)
        {
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index].Key == key)
                {
                    list[index] = new KeyValuePair<string, Func<IEnumerable<TChildSyntax>>>(key, syntax);
                    break;
                }
            }
        }

        public void InsertBefore(string key, string newKey, Func<IEnumerable<TChildSyntax>> syntax)
        {
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index].Key == key)
                {
                    list.Insert(index, new KeyValuePair<string, Func<IEnumerable<TChildSyntax>>>(newKey, syntax));
                    break;
                }
            }
        }

        public void InsertAfter(string key, string newKey, Func<IEnumerable<TChildSyntax>> syntax)
        {
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index].Key == key)
                {
                    list.Insert(index + 1, new KeyValuePair<string, Func<IEnumerable<TChildSyntax>>>(newKey, syntax));
                    break;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        private IEnumerable<TChildSyntax> GetSyntax(
            KeyValuePair<string, Func<IEnumerable<TChildSyntax>>> entry,
            IDictionary<string, IEnumerable<TChildSyntax>> syntaxDictionary)
        {
            return syntaxDictionary.TryGetValue(entry.Key, out IEnumerable<TChildSyntax> syntax) ? syntax : entry.Value();
        }

        private void CombineList(
            Func<KeyValuePair<string, Func<IEnumerable<TChildSyntax>>>, IEnumerable<TChildSyntax>> selectFunc)
        {
            node.Syntax = createList(node.Syntax, list.SelectMany(selectFunc));
        }
    }
}
