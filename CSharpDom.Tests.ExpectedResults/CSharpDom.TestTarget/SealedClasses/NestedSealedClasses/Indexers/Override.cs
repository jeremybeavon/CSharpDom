namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Indexers
{
    public sealed class SealedClassWithNestedSealedClassWithOverrideIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
