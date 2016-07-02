namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public string this[int index]
        {
            set { }
        }
    }
}
