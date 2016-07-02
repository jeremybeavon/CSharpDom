namespace CSharpDom.TestTarget.Classes.NestedStructs.Indexers
{
    public class ClassWithNestedStructWithInternalIndexer
    {
        public struct Struct
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
