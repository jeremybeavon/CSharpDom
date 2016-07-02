namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithIndexerWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
