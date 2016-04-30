namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers
{
    public static class StaticClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers
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
