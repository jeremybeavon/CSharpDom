namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups
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
