namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public string this[int index]
        {
            set { }
        }
    }
}
