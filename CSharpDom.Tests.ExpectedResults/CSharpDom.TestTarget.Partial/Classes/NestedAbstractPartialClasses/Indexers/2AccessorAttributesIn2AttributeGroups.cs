namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers
{
    public class ClassWithNestedAbstractPartialClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public abstract partial class Class
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
