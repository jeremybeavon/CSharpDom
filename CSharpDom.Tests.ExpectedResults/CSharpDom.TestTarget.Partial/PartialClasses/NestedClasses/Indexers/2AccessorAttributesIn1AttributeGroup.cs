namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers
{
    public partial class PartialClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
    {
        public class Class
        {
            public string this[int index]
            {
                [Attribute1, Attribute2]
                get { return default(string); }
                [Attribute1, Attribute2]
                set { }
            }
        }
    }
}
