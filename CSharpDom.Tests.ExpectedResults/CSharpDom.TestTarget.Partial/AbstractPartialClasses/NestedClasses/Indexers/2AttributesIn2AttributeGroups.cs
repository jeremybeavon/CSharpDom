namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups
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
