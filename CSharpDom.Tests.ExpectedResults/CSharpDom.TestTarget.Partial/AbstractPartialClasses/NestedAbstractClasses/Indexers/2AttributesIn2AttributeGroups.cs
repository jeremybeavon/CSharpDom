namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
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
