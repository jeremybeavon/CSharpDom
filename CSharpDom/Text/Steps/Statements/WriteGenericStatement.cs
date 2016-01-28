using CSharpDom.Common.Statements;
using System.Collections.Generic;

namespace CSharpDom.Text.Steps.Statements
{
    public sealed class WriteGenericStatement<TStatement> : ISourceCodeBuilderStep, IHasSourceSourceBuilderSteps, IHasStatement
    {
        public WriteGenericStatement(TStatement statement)
        {
            Statement = statement;
            SourceCodeStatementStepsBuilder builder = new SourceCodeStatementStepsBuilder();
            ((IVisitable<IGenericStatementVisitor>)statement).Accept(builder);
            Steps = builder.Steps;
        }

        public TStatement Statement { get; private set; }

        public List<ISourceCodeBuilderStep> Steps { get; private set; }

        object IHasStatement.Statement
        {
            get { return Statement; }
        }

        public void AddText(SourceCodeTextBuilder builder)
        {
            foreach (ISourceCodeBuilderStep step in Steps)
            {
                step.AddText(builder);
            }
        }
    }
}
