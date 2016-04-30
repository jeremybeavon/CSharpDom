namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithProtectedInternalIndexer
    {
        public abstract class Class
        {
            protected internal string this[int index]
            {
                set { }
            }
        }
    }
}
