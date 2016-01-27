using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class VariableDeclarationStatement : Statement
    {
        public VariableDeclarationStatement()
        {
            VariableDeclarations = new Collection<VariableDeclaration>();
        }

        public bool IsConst { get; set; }

        public TypeReference Type { get; set; }

        public Collection<VariableDeclaration> VariableDeclarations { get; set; }

        public override void Accept(StatementVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(StatementVisitor visitor)
        {
            Type.AcceptIfNotNull(visitor);
            VariableDeclarations.AcceptIfNotNull(visitor);
        }
    }
}
