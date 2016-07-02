namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Indexers
{
    public static class StaticClassWithNestedSealedClassWithIndexerWith2ParametersWithParameters
    {
        public sealed class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
