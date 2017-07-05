namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers
{
    public partial class PartialClassWithNestedSealedClassWithIndexerWith1AccessorAttribute
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
