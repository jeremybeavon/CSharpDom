namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers
{
    public partial class PartialClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
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
