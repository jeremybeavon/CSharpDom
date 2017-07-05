namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Indexers
{
    public class ClassWithNestedStructWithPrivateIndexer
    {
        public struct Struct
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
