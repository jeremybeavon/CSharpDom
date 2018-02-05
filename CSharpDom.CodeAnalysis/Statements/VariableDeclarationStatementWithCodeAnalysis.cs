using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class VariableDeclarationStatementWithCodeAnalysis :
        EditableVariableDeclarationStatement<ITypeReferenceWithCodeAnalysis, IExpressionWithCodeAnalysis>,
        IHasSyntax<LocalDeclarationStatementSyntax>,
        IHasNode<LocalDeclarationStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<VariableDeclarationStatementWithCodeAnalysis, LocalDeclarationStatementSyntax> node;

        internal VariableDeclarationStatementWithCodeAnalysis()
        {
            node = new StatementNode<VariableDeclarationStatementWithCodeAnalysis, LocalDeclarationStatementSyntax>(this);
        }

        public override IList<IExpressionWithCodeAnalysis> Expressions { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public override ITypeReferenceWithCodeAnalysis Type { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public LocalDeclarationStatementSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get => Syntax;
            set => Syntax = (LocalDeclarationStatementSyntax)value;
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node => node;

        INode<LocalDeclarationStatementSyntax> IHasNode<LocalDeclarationStatementSyntax>.Node => node;
    }
}
