namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
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
