namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedPartialClassWithIndexerWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
