namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithInternalIndexer
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
