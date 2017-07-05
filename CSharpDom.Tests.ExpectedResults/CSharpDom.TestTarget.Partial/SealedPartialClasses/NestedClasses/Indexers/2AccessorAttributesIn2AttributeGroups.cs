namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public class Class
        {
            public string this[int index]
            {
                [Attribute1]
                [Attribute2]
                get { return default(string); }
                [Attribute1]
                [Attribute2]
                set { }
            }
        }
    }
}
