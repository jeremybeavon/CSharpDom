namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
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
