namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
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
