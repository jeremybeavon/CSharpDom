namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedPartialClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public partial class Class
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
