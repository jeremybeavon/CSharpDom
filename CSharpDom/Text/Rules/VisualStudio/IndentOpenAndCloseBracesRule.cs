using CSharpDom.Common;
using CSharpDom.Common.Statements;
using CSharpDom.Text.Steps;
using System;
using System.Collections.Generic;

namespace CSharpDom.Text.Rules.VisualStudio
{
    public sealed class IndentOpenAndCloseBracesRule : ISourceCodeStyleRule
    {
        private static readonly Type[] nodeTypes = new Type[]
        {
            typeof(IAccessor),
            typeof(IBlockStatement),
            typeof(IConstructor),
            typeof(IConversionOperator),
            typeof(IMethod),
            typeof(IOperatorOverload)
        };

        public IndentOpenAndCloseBracesRule(bool indentOpenAndCloseBraces)
        {
            IndentOpenAndCloseBraces = indentOpenAndCloseBraces;
        }

        public bool IndentOpenAndCloseBraces { get; set; }

        public bool IsRuleAlreadyApplied
        {
            get { return !IndentOpenAndCloseBraces; }
        }

        public void ApplyRule(List<ISourceCodeBuilderStep> steps)
        {
            /*foreach (ChildSteps childSteps in steps.GetChildSteps(nodeTypes))
            {
                childSteps.Steps.InsertBefore(typeof(WriteStartBrace), new IncrementIndent())
                childSteps.Steps.RemovePrevious(typeof(WriteEndBrace), typeof(DecrementIndent));
            }*/
        }
    }
}
