using System;
using CSharpDom.Common.Expressions;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ConstantWithCodeAnalysis :
        EditableConstant<IExpression>,
        IHasSyntax<VariableDeclaratorSyntax>,
        IHasNode<VariableDeclaratorSyntax>
    {
        private readonly Node<ConstantWithCodeAnalysis, VariableDeclaratorSyntax> node;

        internal ConstantWithCodeAnalysis()
        {
            node = new Node<ConstantWithCodeAnalysis, VariableDeclaratorSyntax>(this);
        }

        public override IExpression ConstantValue
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

        public override string Name
        {
            get { return Syntax.Identifier.Text; }
            set { Syntax = Syntax.WithIdentifier(SyntaxFactory.Identifier(value)); }
        }

        public VariableDeclaratorSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<VariableDeclaratorSyntax> IHasNode<VariableDeclaratorSyntax>.Node
        {
            get { return node; }
        }
    }
}
