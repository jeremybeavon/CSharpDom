namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups
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
