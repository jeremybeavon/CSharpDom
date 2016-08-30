using CSharpDom.Common;
using CSharpDom.Common.Statements;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class MethodBodyWithCodeAnalysis : EditableMethodBody<IStatement>,
        IHasSyntax<BlockSyntax>
    {
        private readonly Node<MethodBodyWithCodeAnalysis, BlockSyntax> node;

        internal MethodBodyWithCodeAnalysis(EventPropertyWithCodeAnalysis parent, EventPropertyBodyType body)
            : this()
        {
            switch (body)
            {
                case EventPropertyBodyType.AddAccessor:
                    EventPropertyAddAccessorParent = parent;
                    break;
                case EventPropertyBodyType.RemoveAccessor:
                    EventPropertyRemoveAccessorParent = parent;
                    break;
            }
        }

        internal MethodBodyWithCodeAnalysis(DestructorWithCodeAnalysis parent)
            : this()
        {
            DestructorParent = parent;
        }

        private MethodBodyWithCodeAnalysis()
        {
            node = new Node<MethodBodyWithCodeAnalysis, BlockSyntax>(this);
        }

        public BlockSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal DestructorWithCodeAnalysis DestructorParent
        {
            get { return node.GetParentNode<DestructorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal EventPropertyWithCodeAnalysis EventPropertyAddAccessorParent
        {
            get { return node.GetParentNode<EventPropertyWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                    value,
                    syntax => syntax.GetAccessor(SyntaxKind.AddKeyword).Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax, SyntaxKind.AddKeyword));
            }
        }

        internal EventPropertyWithCodeAnalysis EventPropertyRemoveAccessorParent
        {
            get { return node.GetParentNode<EventPropertyWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                    value,
                    syntax => syntax.GetAccessor(SyntaxKind.RemoveKeyword).Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax, SyntaxKind.RemoveKeyword));
            }
        }
    }
}
