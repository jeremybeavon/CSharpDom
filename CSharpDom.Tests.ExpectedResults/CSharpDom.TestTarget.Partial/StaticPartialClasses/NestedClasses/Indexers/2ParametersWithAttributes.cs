namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedClassWithIndexerWith2ParametersWithAttributes
    {
        public class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
