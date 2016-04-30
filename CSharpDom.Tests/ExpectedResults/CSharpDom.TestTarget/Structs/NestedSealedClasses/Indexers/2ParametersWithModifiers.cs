namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Indexers
{
    public struct StructWithNestedSealedClassWithIndexerWith2ParametersWithModifiers
    {
        public sealed class Class
        {
            public string this[params string[] descriptions]
            {
                set { }
            }
        }
    }
}
