namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers
{
    public partial class PartialClassWithIndexerWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public string this[int index]
        {
            set { }
        }
    }
}
