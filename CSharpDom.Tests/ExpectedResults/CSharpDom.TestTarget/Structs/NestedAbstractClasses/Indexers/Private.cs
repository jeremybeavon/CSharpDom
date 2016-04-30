namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Indexers
{
    public struct StructWithNestedAbstractClassWithPrivateIndexer
    {
        public abstract class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
