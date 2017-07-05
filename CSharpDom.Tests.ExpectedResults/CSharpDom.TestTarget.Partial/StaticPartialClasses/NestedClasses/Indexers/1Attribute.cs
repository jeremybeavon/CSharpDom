namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedClassWithIndexerWith1Attribute
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
