namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithInternalIndexer
    {
        public abstract class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
