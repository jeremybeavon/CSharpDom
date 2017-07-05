namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedSealedClassWithOverrideIndexer
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
