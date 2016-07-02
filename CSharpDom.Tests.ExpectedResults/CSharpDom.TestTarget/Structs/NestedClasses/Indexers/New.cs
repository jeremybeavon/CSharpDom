namespace CSharpDom.TestTarget.Structs.NestedClasses.Indexers
{
    public struct StructWithNestedClassWithNewIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
