namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers
{
    public static class StaticClassWithNestedClassWithIndexerWith2ParametersWithParameters
    {
        public class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
