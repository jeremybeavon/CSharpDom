namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithIndexerWith2ParametersWithAttributes
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
