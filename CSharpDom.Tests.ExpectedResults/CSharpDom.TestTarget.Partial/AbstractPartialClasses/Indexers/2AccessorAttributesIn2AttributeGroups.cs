namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public string this[int index]
        {
            [Attribute1]
            [Attribute2]
            get { return default(string); }
            [Attribute1]
            [Attribute2]
            set { }
        }
    }
}
