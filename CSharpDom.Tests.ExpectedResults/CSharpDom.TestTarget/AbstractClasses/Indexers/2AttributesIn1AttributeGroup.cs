namespace CSharpDom.TestTarget.AbstractClasses.Indexers
{
    public abstract class AbstractClassWithIndexerWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public string this[int index]
        {
            set { }
        }
    }
}
