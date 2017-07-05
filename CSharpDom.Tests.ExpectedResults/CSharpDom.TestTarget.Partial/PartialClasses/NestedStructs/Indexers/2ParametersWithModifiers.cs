namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Indexers
{
    public partial class PartialClassWithNestedStructWithIndexerWith2ParametersWithModifiers
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
