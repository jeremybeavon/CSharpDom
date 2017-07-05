namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Indexers
{
    public struct StructWithNestedAbstractPartialClassWithOverrideIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
