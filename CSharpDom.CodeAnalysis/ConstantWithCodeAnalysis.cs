using System;
using CSharpDom.Common.Expressions;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ConstantWithCodeAnalysis : EditableConstant<IExpression>, IHasSyntax<VariableDeclaratorSyntax>, IHasId
    {
        private readonly SimpleNode<
            ConstantGroupWithCodeAnalysis,
            FieldDeclarationSyntax,
            ConstantWithCodeAnalysis,
            VariableDeclaratorSyntax> node;

        public ConstantWithCodeAnalysis(ConstantGroupWithCodeAnalysis parent)
        {
            node = new SimpleNode<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax, ConstantWithCodeAnalysis, VariableDeclaratorSyntax>(
                parent,
                this,
                newParent => newParent.FieldList);
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

        internal ConstantGroupWithCodeAnalysis Parent
        {
            get { return node.Parent; }
            set { node.Parent = value; }
        }

        Guid IHasId.InternalId
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
