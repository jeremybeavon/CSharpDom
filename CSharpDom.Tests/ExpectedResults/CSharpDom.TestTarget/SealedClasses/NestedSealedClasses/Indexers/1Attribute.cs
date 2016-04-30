namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedClassWithIndexerWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
