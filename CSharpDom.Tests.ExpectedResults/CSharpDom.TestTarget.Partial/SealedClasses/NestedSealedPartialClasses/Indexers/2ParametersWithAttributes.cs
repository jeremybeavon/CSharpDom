namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public sealed partial class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
