namespace CSharpDom.TestTarget.AbstractClasses.Indexers
{
    public abstract class AbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
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
