using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteMethodParameterModifier : ISourceCodeBuilderStep
    {
        public WriteMethodParameterModifier(ParameterModifier modifier)
        {
            Modifier = modifier;
        }

        public ParameterModifier Modifier { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (Modifier)
            {
                case ParameterModifier.Out:
                    builder.Append("out");
                    break;
                case ParameterModifier.Params:
                    builder.Append("params");
                    break;
                case ParameterModifier.Ref:
                    builder.Append("ref");
                    break;
            }
        }
    }
}
