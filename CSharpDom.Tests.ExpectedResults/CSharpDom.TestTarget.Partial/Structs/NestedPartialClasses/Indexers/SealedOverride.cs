namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Indexers
{
    public struct StructWithNestedPartialClassWithSealedOverrideIndexer
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
