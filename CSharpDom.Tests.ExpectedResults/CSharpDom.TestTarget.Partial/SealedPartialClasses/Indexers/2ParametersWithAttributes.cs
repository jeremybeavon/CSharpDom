namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers
{
    public sealed partial class SealedPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
