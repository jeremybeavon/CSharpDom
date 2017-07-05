namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Indexers
{
    public abstract class AbstractClassWithNestedStructWithIndexerWith2ParametersWithModifiers
    {
        public struct Struct
        {
            public string this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
