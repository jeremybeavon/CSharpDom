namespace CSharpDom.Text.Steps.Expressions
{
    public sealed class WriteQueryOrderByType : ISourceCodeBuilderStep
    {
        public WriteQueryOrderByType(QueryOrderByType orderByType)
        {
            OrderByType = orderByType;
        }

        public QueryOrderByType OrderByType { get; private set; }

        public void AddText(SourceCodeTextBuilder builder)
        {
            switch (OrderByType)
            {
                case QueryOrderByType.Ascending:
                    builder.Append("ascending");
                    break;
                case QueryOrderByType.Descending:
                    builder.Append("descending");
                    break;
            }
        }
    }
}
