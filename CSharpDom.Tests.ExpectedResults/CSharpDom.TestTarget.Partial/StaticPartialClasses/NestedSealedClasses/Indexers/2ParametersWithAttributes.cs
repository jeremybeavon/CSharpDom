namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes
    {
        public sealed class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
