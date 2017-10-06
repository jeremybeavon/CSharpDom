using System;
using CSharpDom.CodeAnalysis.Expressions;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class FieldWithCodeAnalysis :
        EditableField<IExpressionWithCodeAnalysis>, 
        IHasSyntax<VariableDeclaratorSyntax>,
        IHasNode<VariableDeclaratorSyntax>
    {
        private readonly Node<FieldWithCodeAnalysis, VariableDeclaratorSyntax> node;
        private readonly CachedExpressionNode<FieldWithCodeAnalysis, VariableDeclaratorSyntax> initialValue;

        public FieldWithCodeAnalysis(string name)
            : this()
        {
            Syntax = SyntaxFactory.VariableDeclarator(name);
        }

        internal FieldWithCodeAnalysis()
        {
            node = new Node<FieldWithCodeAnalysis, VariableDeclaratorSyntax>(this);
            initialValue = new CachedExpressionNode<FieldWithCodeAnalysis, VariableDeclaratorSyntax>(
                node,
                syntax => syntax.Initializer.Value,
                VariableDeclaratorSyntaxExtensions.WithInitialValue);
        }
        
        public override IExpressionWithCodeAnalysis InitialValue
        {
            get { return initialValue.Value; }
            set { initialValue.Value = value; }
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
