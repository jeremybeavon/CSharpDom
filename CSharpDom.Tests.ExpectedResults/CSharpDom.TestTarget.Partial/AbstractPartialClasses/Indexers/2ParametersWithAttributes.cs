namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
