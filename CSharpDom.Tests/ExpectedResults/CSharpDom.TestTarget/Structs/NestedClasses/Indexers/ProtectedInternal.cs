namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers
{
    public struct StructWithNestedClassWithProtectedInternalIndexer
    {
        public class Class
        {
            protected internal string this[int index]
            {
                set { }
            }
        }
    }
}
