namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers
{
    public struct StructWithNestedAbstractPartialClassWithNewIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
