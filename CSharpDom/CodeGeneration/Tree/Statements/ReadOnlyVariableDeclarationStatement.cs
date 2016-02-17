using CSharpDom.BaseClasses.Statements;
using CSharpDom.CodeGeneration.Tree.Types;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyVariableDeclarationStatement :
        AbstractVariableDeclarationStatement<ReadOnlyTypeReference, ReadOnlyVariableDeclaration>
    {
        private readonly IReadOnlyList<ReadOnlyVariableDeclaration> expressions;
        private readonly ReadOnlyTypeReference type;

        public ReadOnlyVariableDeclarationStatement(VariableDeclarationStatement variableDeclarationStatement)
        {
            expressions = variableDeclarationStatement.VariableDeclarations.ToArray(
                variable => new ReadOnlyVariableDeclaration(variable));
            type = new ReadOnlyTypeReference(variableDeclarationStatement.Type);
        }

        public override IReadOnlyList<ReadOnlyVariableDeclaration> Expressions
        {
            get { return expressions; }
        }

        public override ReadOnlyTypeReference Type
        {
            get { return type; }
        }
    }
}
