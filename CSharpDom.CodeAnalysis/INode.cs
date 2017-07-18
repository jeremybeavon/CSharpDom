using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal interface INode<TSyntax> : IHasSyntax<TSyntax>
    {
        Guid InternalId { get; }

        TParentNode GetParentNode<TParentNode>()
            where TParentNode : class;

        void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TSyntax> getChildSyntax,
            Func<TParentSyntax, TSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>;

        void SetParentNode<TParentNode, TParentSyntax, TChildNode>(
            TParentNode parent,
            TChildNode child,
            IChildCollection<TChildNode, TSyntax> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>;

        void RemoveParentNode();
    }
}
