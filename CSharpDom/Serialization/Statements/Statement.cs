using System;
using System.ComponentModel;
using CSharpDom.Common.Statements;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Serialization.Statements
{
    public sealed class Statement : IStatement
    {
        [DefaultValue(null)]
        public BlockStatement BlockStatement { get; set; }

        [DefaultValue(null)]
        public BreakStatement BreakStatement { get; set; }

        [DefaultValue(null)]
        public ContinueStatement ContinueStatement { get; set; }

        [DefaultValue(null)]
        public DoStatement DoStatement { get; set; }

        [DefaultValue(null)]
        public EmptyStatement EmptyStatement { get; set; }

        [DefaultValue(null)]
        public ExpressionStatement ExpressionStatement { get; set; }

        [DefaultValue(null)]
        public ForeachStatement ForeachStatement { get; set; }

        [DefaultValue(null)]
        public ForStatement ForStatement { get; set; }

        [DefaultValue(null)]
        public GotoCaseStatement GotoCaseStatement { get; set; }

        [DefaultValue(null)]
        public GotoStatement GotoStatement { get; set; }

        [DefaultValue(null)]
        public IfStatement IfStatement { get; set; }

        [DefaultValue(null)]
        public LabelStatement LabelStatement { get; set; }

        [DefaultValue(null)]
        public LockStatement LockStatement { get; set; }

        [DefaultValue(null)]
        public ReturnStatement ReturnStatement { get; set; }

        [DefaultValue(null)]
        public SwitchStatement SwitchStatement { get; set; }

        [DefaultValue(null)]
        public TryStatement TryStatement { get; set; }

        [DefaultValue(null)]
        public UsingStatement UsingStatement { get; set; }

        [DefaultValue(null)]
        public VariableDeclarationStatement VariableDeclarationStatement { get; set; }

        [DefaultValue(null)]
        public WhileStatement WhileStatement { get; set; }

        private IEnumerable<IStatement> Statements
        {
            get
            {
                yield return BlockStatement;
                yield return BreakStatement;
                yield return ContinueStatement;
                yield return DoStatement;
                yield return EmptyStatement;
                yield return ExpressionStatement;
                yield return ForeachStatement;
                yield return ForStatement;
                yield return GotoCaseStatement;
                yield return GotoStatement;
                yield return IfStatement;
                yield return LabelStatement;
                yield return LockStatement;
                yield return ReturnStatement;
                yield return SwitchStatement;
                yield return TryStatement;
                yield return UsingStatement;
                yield return VariableDeclarationStatement;
                yield return WhileStatement;
            }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            IStatement statement = Statements.FirstOrDefault(current => current != null);
            if (statement != null)
            {
                statement.Accept(visitor);
            }
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            IStatement statement = Statements.FirstOrDefault(current => current != null);
            if (statement != null)
            {
                statement.AcceptChildren(visitor);
            }
        }
    }
}
