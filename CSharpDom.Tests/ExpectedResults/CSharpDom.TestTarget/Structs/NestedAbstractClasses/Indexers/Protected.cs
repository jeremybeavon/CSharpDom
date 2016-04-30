namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithProtectedIndexer
    {
        public abstract class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
