namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedPartialClassWithIndexerWith1AccessorAttribute
    {
        public partial class Class
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
