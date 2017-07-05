namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithIndexerWith1AccessorAttribute
    {
        public class Class
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
