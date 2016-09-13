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
    public sealed class MethodBodyWithCodeAnalysis :
        EditableMethodBody<IStatement>,
        IHasSyntax<BlockSyntax>,
        IHasNode<BlockSyntax>
    {
        private readonly Node<MethodBodyWithCodeAnalysis, BlockSyntax> node;

        internal MethodBodyWithCodeAnalysis(AccessorWithCodeAnalysis parent)
            : this()
        {
            AccessorParent = parent;
        }

        internal MethodBodyWithCodeAnalysis(ConstructorWithCodeAnalysis parent)
            : this()
        {
            ConstructorParent = parent;
        }

        internal MethodBodyWithCodeAnalysis(ConversionOperatorWithCodeAnalysis parent)
            : this()
        {
            ConversionOperatorParent = parent;
        }

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

        internal MethodBodyWithCodeAnalysis(MethodWithCodeAnalysis parent)
            : this()
        {
            MethodParent = parent;
        }

        internal MethodBodyWithCodeAnalysis(OperatorOverloadWithCodeAnalysis parent)
            : this()
        {
            OperatorOverloadParent = parent;
        }

        internal MethodBodyWithCodeAnalysis(StaticConstructorWithCodeAnalysis parent)
            : this()
        {
            StaticConstructorParent = parent;
        }

        internal MethodBodyWithCodeAnalysis()
        {
            node = new Node<MethodBodyWithCodeAnalysis, BlockSyntax>(this);
        }

        public override IList<IStatement> Statements
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public BlockSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal AccessorWithCodeAnalysis AccessorParent
        {
            get { return node.GetParentNode<AccessorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal ConstructorWithCodeAnalysis ConstructorParent
        {
            get { return node.GetParentNode<ConstructorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal ConversionOperatorWithCodeAnalysis ConversionOperatorParent
        {
            get { return node.GetParentNode<ConversionOperatorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
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

        internal MethodWithCodeAnalysis MethodParent
        {
            get { return node.GetParentNode<MethodWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<MethodWithCodeAnalysis, MethodDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal OperatorOverloadWithCodeAnalysis OperatorOverloadParent
        {
            get { return node.GetParentNode<OperatorOverloadWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal StaticConstructorWithCodeAnalysis StaticConstructorParent
        {
            get { return node.GetParentNode<StaticConstructorWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }
        
        INode<BlockSyntax> IHasNode<BlockSyntax>.Node
        {
            get { return node; }
        }
    }
}
