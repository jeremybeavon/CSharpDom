using System;

namespace CSharpDom.CodeAnalysis
{
    internal interface INode<TSyntax> : IHasSyntax<TSyntax>
    {
        Guid InternalId { get; }

        bool IsLocked { get; set; }

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
            IChildCollection<TParentSyntax, TChildNode, TSyntax> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>;

        void RemoveParentNode();
    }
}
