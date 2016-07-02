namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers
{
    public struct StructWithNestedClassWithSealedOverrideIndexer
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
