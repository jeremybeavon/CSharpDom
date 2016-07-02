namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithIndexerWith1AccessorAttribute
    {
        public struct Struct
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
