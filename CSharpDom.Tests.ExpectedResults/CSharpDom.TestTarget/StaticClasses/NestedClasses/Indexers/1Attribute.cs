namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Indexers
{
    public static class StaticClassWithNestedClassWithIndexerWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
