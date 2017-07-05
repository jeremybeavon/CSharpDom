namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes
    {
        public abstract class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
