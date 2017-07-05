namespace CSharpDom.TestTarget.Partial.PartialClasses.Indexers
{
    public partial class PartialClassWithIndexerWith1AccessorAttribute
    {
        public string this[int index]
        {
            [Attribute1]
            get { return default(string); }
            [Attribute1]
            set { }
        }
    }
}
