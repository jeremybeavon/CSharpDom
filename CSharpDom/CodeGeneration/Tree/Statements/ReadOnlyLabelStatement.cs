using System;
using CSharpDom.BaseClasses.Statements;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyLabelStatement : AbstractLabelStatement
    {
        private readonly string labelName;

        public ReadOnlyLabelStatement(LabelStatement statement)
        {
            labelName = statement.Label.Label;
        }

        public override string LabelName
        {
            get { return labelName; }
        }
    }
}
