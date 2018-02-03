using System;

namespace CSharpDom.CodeAnalysis
{
    internal interface INode<TSyntax> : INode, IHasSyntax<TSyntax>
    {
        int Index { get; set; }

        bool IsLocked { get; set; }

        TParent GetParent<TParent>()
            where TParent : class;

        void SetParent<TParent, TParentSyntax>(
            TParent parent,
            Func<TParentSyntax, TSyntax> getChildSyntax,
            Func<TParentSyntax, TSyntax, TParentSyntax> createChildSyntax)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class;

        void SetParent<TParent, TParentSyntax>(
            TParent parent,
            int childIndex,
            Func<int, TSyntax> getChildSyntax,
            Func<int, TSyntax, TParentSyntax> createChildSyntax)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class;
        
        void RemoveParentNode();
    }
}
