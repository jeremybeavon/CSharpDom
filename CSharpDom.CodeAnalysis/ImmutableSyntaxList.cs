using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ImmutableSyntaxList<TItem> : IImmutableList<SyntaxList<TItem>, TItem>
        where TItem : SyntaxNode
    {
        public SyntaxList<TItem> Add(SyntaxList<TItem> list, TItem item)
        {
            return list.Add(item);
        }

        public SyntaxList<TItem> Insert(SyntaxList<TItem> list, int index, TItem item)
        {
            return list.Insert(index, item);
        }

        public SyntaxList<TItem> Remove(SyntaxList<TItem> list, TItem item)
        {
            return list.Remove(item);
        }

        public SyntaxList<TItem> RemoveAt(SyntaxList<TItem> list, int index)
        {
            return list.RemoveAt(index);
        }

        public SyntaxList<TItem> Replace(SyntaxList<TItem> list, TItem oldItem, TItem newItem)
        {
            return list.Replace(oldItem, newItem);
        }
    }
}
