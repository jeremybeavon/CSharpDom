namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithPublicIndexer
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
