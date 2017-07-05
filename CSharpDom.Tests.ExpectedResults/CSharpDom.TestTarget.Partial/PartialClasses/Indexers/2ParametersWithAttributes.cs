namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers
{
    public partial class PartialClassWithIndexerWith2ParametersWithAttributes
    {
        public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
