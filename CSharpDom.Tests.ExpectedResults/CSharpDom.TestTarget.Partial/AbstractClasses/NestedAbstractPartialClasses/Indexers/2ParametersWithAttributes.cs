namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public abstract partial class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
