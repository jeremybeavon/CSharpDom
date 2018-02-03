using System;

namespace CSharpDom.CodeAnalysis
{
    internal interface INode<TSyntax> : INode, IHasSyntax<TSyntax>
    {
        int Index { get; set; }

        bool IsLocked { get; set; }

        TParentNode GetParent<TParentNode>()
            where TParentNode : class;

        void SetParent<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TSyntax> getChildSyntax,
            Func<TParentSyntax, TSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasNode<TParentSyntax>
            where TParentSyntax : class;

        void SetParent<TParentNode, TParentSyntax>(
            TParentNode parent,
            int childIndex,
            Func<int, TSyntax> getChildSyntax,
            Func<int, TSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasNode<TParentSyntax>
            where TParentSyntax : class;
        
        void RemoveParentNode();
    }
}
