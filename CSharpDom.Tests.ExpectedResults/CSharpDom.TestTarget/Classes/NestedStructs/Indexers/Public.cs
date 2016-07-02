namespace CSharpDom.TestTarget.Classes.NestedStructs.Indexers
{
    public class ClassWithNestedStructWithPublicIndexer
    {
        public struct Struct
        {
            public string this[int index]
            {
                set { }
            }
        }
    }
}
