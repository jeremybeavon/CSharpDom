namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithIndexerWith2ParametersWithAttributes
    {
        public abstract class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
