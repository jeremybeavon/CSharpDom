using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal static class ChildNodeFactory
    {
        public static Func<TParentSyntax, TChildSyntax> GetChildSyntax<TParentSyntax, TChildNode, TChildSyntax>(
            TChildNode child,
            Func<IChildCollection<TChildNode, TChildSyntax>> getCollection)
        {
            return syntax => getCollection().GetChild(child);
        }

        public static Func<TParentSyntax, TChildSyntax, TParentSyntax> CreateChildSyntax<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(
            TParentNode parent,
            TChildNode child,
            Func<IChildCollection<TChildNode, TChildSyntax>> getCollection)
            where TParentNode : IHasSyntax<TParentSyntax>
        {
            return (parentSyntax, childSyntax) =>
            {
                getCollection().SetChild(child, childSyntax);
                return parent.Syntax;
            };
        }
    }
}
