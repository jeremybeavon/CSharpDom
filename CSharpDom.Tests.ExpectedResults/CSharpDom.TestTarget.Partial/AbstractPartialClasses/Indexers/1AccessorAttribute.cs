namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithIndexerWith1AccessorAttribute
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
