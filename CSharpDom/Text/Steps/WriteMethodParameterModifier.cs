using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteMethodParameterModifier : ISourceCodeBuilderStep
    {
        public WriteMethodParameterModifier(MethodParameterModifier modifier)
        {
            Modifier = modifier;
        }

        public MethodParameterModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case MethodParameterModifier.Out:
                    builder.Append("out");
                    break;
                case MethodParameterModifier.Params:
                    builder.Append("params");
                    break;
                case MethodParameterModifier.Ref:
                    builder.Append("ref");
                    break;
                case MethodParameterModifier.This:
                    builder.Append("this");
                    break;
            }
        }
    }
}
