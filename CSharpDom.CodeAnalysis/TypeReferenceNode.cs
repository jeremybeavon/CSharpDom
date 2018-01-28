using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class TypeReferenceNode<TValue, TSyntax> : Node<TValue, TSyntax>, INode<TypeSyntax>
        where TValue : IInternalTypeReferenceWithCodeAnalysis
        where TSyntax : TypeSyntax
    {
        public TypeReferenceNode(TValue value)
            : base(value)
        {
        }

        TypeSyntax IHasSyntax<TypeSyntax>.Syntax { get => Syntax; set => Syntax = (TSyntax)value; }
        
        void INode<TypeSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, TypeSyntax> getChildSyntax,
            Func<TParentSyntax, TypeSyntax, TParentSyntax> createChildSyntax)
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                syntax => (TSyntax)getChildSyntax(syntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        void INode<TypeSyntax>.SetParentNode<TParentNode, TParentSyntax, TChildNode>(
            TParentNode parent,
            TChildNode child,
            IChildCollection<TParentSyntax, TChildNode, TypeSyntax> getCollection)
        {
            SetParentNode(
                parent,
                child,
                new SimpleChildCollection<TParentSyntax, TChildNode, TypeSyntax, TSyntax>(getCollection));
        }
    }
}
