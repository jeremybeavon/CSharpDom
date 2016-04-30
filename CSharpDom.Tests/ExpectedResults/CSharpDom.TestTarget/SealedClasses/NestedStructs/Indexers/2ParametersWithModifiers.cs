namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Indexers
{
    public sealed class SealedClassWithNestedStructWithIndexerWith2ParametersWithModifiers
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
