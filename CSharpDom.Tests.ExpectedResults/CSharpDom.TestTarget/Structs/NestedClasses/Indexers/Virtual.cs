namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers
{
    public struct StructWithNestedClassWithVirtualIndexer
    {
        public class Class
        {
            public virtual string this[int index]
            {
                set { }
            }
        }
    }
}
