namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers
{
    public struct StructWithNestedClassWithInternalIndexer
    {
        public class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
