using System;
using System.Collections.Generic;

namespace CSharpDom.Text
{
    public sealed class SourceCodeStepRange
    {
        private readonly SourceCodePlaceholder startPlaceholder;
        private readonly SourceCodePlaceholder endPlaceholder;

        internal SourceCodeStepRange(
            List<ISourceCodeBuilderStep> list,
            List<ISourceCodeBuilderStep> range,
            SourceCodePlaceholder startPlaceholder,
            SourceCodePlaceholder endPlaceholder)
        {
            OriginalList = list;
            Range = range;
            this.startPlaceholder = startPlaceholder;
            this.endPlaceholder = endPlaceholder;
        }

        public List<ISourceCodeBuilderStep> Range { get; private set; }

        public List<ISourceCodeBuilderStep> OriginalList { get; private set; }

        public void Apply()
        {
            int? startIndex = OriginalList.FindIndex(startPlaceholder);
            if (!startIndex.HasValue)
            {
                throw new InvalidOperationException($"Start placeholder not found: {startPlaceholder}");
            }

            int? endIndex = OriginalList.FindIndex(endPlaceholder);
            if (!endIndex.HasValue)
            {
                throw new InvalidOperationException($"End placeholder not found: {endPlaceholder}");
            }

            int length = endIndex.Value - startIndex.Value;
            if (length <= 0)
            {
                throw new InvalidOperationException($"Invalid length between {startPlaceholder} and {endPlaceholder}");
            }

            OriginalList.RemoveRange(startIndex.Value, length);
            OriginalList.InsertRange(startIndex.Value, Range);
        }
    }
}
