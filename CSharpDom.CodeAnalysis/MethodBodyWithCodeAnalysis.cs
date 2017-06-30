using CSharpDom.Common;
using CSharpDom.Common.Statements;
using CSharpDom.CodeAnalysis.Statements;
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
        EditableMethodBody<IStatementWithCodeAnalysis>,
        IHasSyntax<BlockSyntax>,
        IHasNode<BlockSyntax>
    {
        private readonly BlockStatementWithCodeAnalysis block;

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
            block = new BlockStatementWithCodeAnalysis();
        }

        public override IList<IStatementWithCodeAnalysis> Statements
        {
            get { return block.Statements; }
            set { block.Statements = value; }
        }

        public BlockSyntax Syntax
        {
            get { return Node.Syntax; }
            set { Node.Syntax = value; }
        }

        internal AccessorWithCodeAnalysis AccessorParent
        {
            get { return Node.GetParentNode<AccessorWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal ConstructorWithCodeAnalysis ConstructorParent
        {
            get { return Node.GetParentNode<ConstructorWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<ConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal ConversionOperatorWithCodeAnalysis ConversionOperatorParent
        {
            get { return Node.GetParentNode<ConversionOperatorWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<ConversionOperatorWithCodeAnalysis, ConversionOperatorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal DestructorWithCodeAnalysis DestructorParent
        {
            get { return Node.GetParentNode<DestructorWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<DestructorWithCodeAnalysis, DestructorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal EventPropertyWithCodeAnalysis EventPropertyAddAccessorParent
        {
            get { return Node.GetParentNode<EventPropertyWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                    value,
                    syntax => syntax.GetAccessor(SyntaxKind.AddKeyword).Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax, SyntaxKind.AddKeyword));
            }
        }

        internal EventPropertyWithCodeAnalysis EventPropertyRemoveAccessorParent
        {
            get { return Node.GetParentNode<EventPropertyWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<EventPropertyWithCodeAnalysis, EventDeclarationSyntax>(
                    value,
                    syntax => syntax.GetAccessor(SyntaxKind.RemoveKeyword).Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax, SyntaxKind.RemoveKeyword));
            }
        }

        internal MethodWithCodeAnalysis MethodParent
        {
            get { return Node.GetParentNode<MethodWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<MethodWithCodeAnalysis, MethodDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal OperatorOverloadWithCodeAnalysis OperatorOverloadParent
        {
            get { return Node.GetParentNode<OperatorOverloadWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<OperatorOverloadWithCodeAnalysis, OperatorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }

        internal StaticConstructorWithCodeAnalysis StaticConstructorParent
        {
            get { return Node.GetParentNode<StaticConstructorWithCodeAnalysis>(); }
            set
            {
                Node.SetParentNode<StaticConstructorWithCodeAnalysis, ConstructorDeclarationSyntax>(
                    value,
                    syntax => syntax.Body,
                    (parentSyntax, childSyntax) => parentSyntax.WithBody(childSyntax));
            }
        }
        
        INode<BlockSyntax> IHasNode<BlockSyntax>.Node
        {
            get { return Node; }
        }

        private StatementNode<BlockStatementWithCodeAnalysis, BlockSyntax> Node => block.Node;
    }
}
