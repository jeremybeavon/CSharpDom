namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithPrivateIndexer
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
