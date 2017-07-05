namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithIndexerWith2AttributesIn2AttributeGroups
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
