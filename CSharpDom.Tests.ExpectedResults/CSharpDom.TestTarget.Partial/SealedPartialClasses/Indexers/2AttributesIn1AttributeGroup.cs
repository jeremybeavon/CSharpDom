namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers
{
    public sealed partial class SealedPartialClassWithIndexerWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public string this[int index]
        {
            set { }
        }
    }
}
