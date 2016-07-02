namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers
{
    public struct StructWithNestedClassWithProtectedIndexer
    {
        public class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
