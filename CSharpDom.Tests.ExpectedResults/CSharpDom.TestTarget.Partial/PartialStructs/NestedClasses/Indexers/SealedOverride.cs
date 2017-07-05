namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Indexers
{
    public partial struct PartialStructWithWithNestedClassWithSealedOverrideIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
