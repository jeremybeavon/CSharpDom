using System;
using System.Collections.Generic;

namespace CSharpDom.Text.Steps
{
    public sealed class WriteBuiltInType : ISourceCodeBuilderStep
    {
        public WriteBuiltInType(BuiltInType builtInType)
        {
            BuiltInType = builtInType;
        }

        public BuiltInType BuiltInType { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            builder.Append(BuiltInType.ToString().ToLower());
        }
    }
}
