namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithIndexerWith1Attribute
    {
        [Attribute1]
        public string this[int index]
        {
            set { }
        }
    }
}
