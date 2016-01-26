using CSharpDom.BaseClasses.Statements;
using System.Collections.Generic;
using CSharpDom.Common.Statements;
using CSharpDom.Text.Steps;

namespace CSharpDom.Text
{
    public sealed class SourceCodeStatementStepsBuilder : AbstractGenericStatementVisitor
    {
        public SourceCodeStatementStepsBuilder()
        {
            Steps = new List<ISourceCodeBuilderStep>();
        }
        
        public List<ISourceCodeBuilderStep> Steps { get; private set; }

        public override void VisitEmptyStatement(IEmptyStatement emptyStatement)
        {
            Steps.Add(new WriteSemicolon());
        }
    }
}
