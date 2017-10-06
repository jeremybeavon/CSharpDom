using System;
using CSharpDom.Common.Expressions;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ConstantWithCodeAnalysis :
        EditableConstant<IExpressionWithCodeAnalysis>,
        IHasSyntax<VariableDeclaratorSyntax>,
        IHasNode<VariableDeclaratorSyntax>
    {
        private readonly Node<ConstantWithCodeAnalysis, VariableDeclaratorSyntax> node;
        private readonly CachedExpressionNode<ConstantWithCodeAnalysis, VariableDeclaratorSyntax> constantValue;

        public ConstantWithCodeAnalysis(string name, IExpressionWithCodeAnalysis value)
            : this()
        {
            Syntax = SyntaxFactory.VariableDeclarator(
                SyntaxFactory.Identifier(name),
                null,
                SyntaxFactory.EqualsValueClause(value.Syntax));
        }

        internal ConstantWithCodeAnalysis()
        {
            node = new Node<ConstantWithCodeAnalysis, VariableDeclaratorSyntax>(this);
            constantValue = new CachedExpressionNode<ConstantWithCodeAnalysis, VariableDeclaratorSyntax>(
                node,
                syntax => syntax.Initializer.Value,
                VariableDeclaratorSyntaxExtensions.WithInitialValue);
        }

        public override IExpressionWithCodeAnalysis ConstantValue
        {
            get { return constantValue.Value; }
            set { constantValue.Value = value; }
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
