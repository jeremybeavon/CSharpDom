using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ImmutableSeparatedSyntaxList<TItem> : IImmutableList<SeparatedSyntaxList<TItem>, TItem>
        where TItem : SyntaxNode
    {
        public SeparatedSyntaxList<TItem> Add(SeparatedSyntaxList<TItem> list, TItem item)
        {
            return list.Add(item);
        }

        public SeparatedSyntaxList<TItem> Insert(SeparatedSyntaxList<TItem> list, int index, TItem item)
        {
            return list.Insert(index, item);
        }

        public SeparatedSyntaxList<TItem> Remove(SeparatedSyntaxList<TItem> list, TItem item)
        {
            return list.Remove(item);
        }

        public SeparatedSyntaxList<TItem> RemoveAt(SeparatedSyntaxList<TItem> list, int index)
        {
            return list.RemoveAt(index);
        }

        public SeparatedSyntaxList<TItem> Replace(SeparatedSyntaxList<TItem> list, TItem oldItem, TItem newItem)
        {
            return list.Replace(oldItem, newItem);
        }
    }
}
