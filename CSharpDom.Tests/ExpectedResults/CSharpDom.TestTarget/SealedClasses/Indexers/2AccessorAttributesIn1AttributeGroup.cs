namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
    {
        public string this[int index]
        {
            [Attribute1, Attribute2]
            get { return default(string); }
            [Attribute1, Attribute2]
            set { }
        }
    }
}
