namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers
{
    public partial class PartialClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute
    {
        public abstract class Class
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
