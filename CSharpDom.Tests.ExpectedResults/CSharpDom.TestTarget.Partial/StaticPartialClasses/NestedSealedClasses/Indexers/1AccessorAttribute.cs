namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedSealedClassWithIndexerWith1AccessorAttribute
    {
        public sealed class Class
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
