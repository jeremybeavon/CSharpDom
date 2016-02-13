namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public string this[int index]
        {
            set { }
        }
    }
}
