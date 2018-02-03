﻿using System;

namespace CSharpDom.CodeAnalysis
{
    internal interface INode<TSyntax> : IHasSyntax<TSyntax>
    {
        int Index { get; set; }

        bool IsLocked { get; set; }

        TParentNode GetParentNode<TParentNode>()
            where TParentNode : class;

        void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TSyntax> getChildSyntax,
            Func<TParentSyntax, TSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasNode<TParentSyntax>
            where TParentSyntax : class;

        void SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            int childIndex,
            Func<TParentSyntax, int, TSyntax> getChildSyntax,
            Func<TParentSyntax, int, TSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasNode<TParentSyntax>
            where TParentSyntax : class;
        
        void RemoveParentNode();
    }
}
