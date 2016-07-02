namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithVirtualIndexer
    {
        public abstract class Class
        {
            public virtual string this[int index]
            {
                set { }
            }
        }
    }
}
