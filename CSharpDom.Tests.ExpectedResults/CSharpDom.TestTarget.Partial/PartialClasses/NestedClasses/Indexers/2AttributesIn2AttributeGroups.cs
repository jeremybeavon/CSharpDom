namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers
{
    public partial class PartialClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
