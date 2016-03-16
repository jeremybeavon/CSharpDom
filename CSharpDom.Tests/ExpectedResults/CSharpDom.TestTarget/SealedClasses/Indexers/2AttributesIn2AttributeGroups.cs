namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public string this[int index]
        {
            set { }
        }
    }
}
