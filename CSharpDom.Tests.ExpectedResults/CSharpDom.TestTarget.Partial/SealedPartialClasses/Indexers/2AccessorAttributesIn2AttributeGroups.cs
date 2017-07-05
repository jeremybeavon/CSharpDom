namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers
{
    public sealed partial class SealedPartialClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
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
