using CSharpDom.Common;
using CSharpDom.Common.Statements;
using CSharpDom.Text.Steps;
using System;
using System.Collections.Generic;

namespace CSharpDom.Text.Rules.VisualStudio
{
    public sealed class IndentBlockContentsRule : ISourceCodeStyleRule
    {
        private static readonly Type[] nodeTypes = new Type[]
        {
            typeof(IClassAccessor),
            typeof(IBlockStatement),
            typeof(IClassConstructor),
            typeof(IConversionOperator),
            typeof(IClassMethod),
            typeof(IOperatorOverload)
        };

        public IndentBlockContentsRule(bool indentBlockContents)
        {
            IndentBlockContents = indentBlockContents;
        }

        public bool IndentBlockContents { get; private set; }

        public bool IsRuleAlreadyApplied
        {
            get { return IndentBlockContents; }
        }

        public void ApplyRule(List<ISourceCodeBuilderStep> steps)
        {
            foreach (ChildSteps childSteps in steps.GetChildSteps(nodeTypes))
            {
                childSteps.Steps.RemoveNext(typeof(WriteStartBrace), typeof(IncrementIndent));
                childSteps.Steps.RemovePrevious(typeof(WriteEndBrace), typeof(DecrementIndent));
            }
        }
    }
}
