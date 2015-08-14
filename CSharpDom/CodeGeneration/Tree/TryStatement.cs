﻿namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class TryStatement : Statement
    {
        public TryStatement()
        {
            TryStatements = new CodeGenerationCollection<Statement>();
            CatchStatements = new CodeGenerationCollection<CatchStatement>();
        }

        public CodeGenerationCollection<Statement> TryStatements { get; set; }

        public CodeGenerationCollection<CatchStatement> CatchStatements { get; set; }

        public FinallyStatement FinallyStatement { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            TryStatements.AcceptIfNotNull(visitor);
            CatchStatements.AcceptIfNotNull(visitor);
            FinallyStatement.AcceptIfNotNull(visitor);
        }
    }
}
