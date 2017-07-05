namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers
{
    public class ClassWithNestedAbstractPartialClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract partial class Class
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
