namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers
{
    public sealed partial class SealedPartialClassWithIndexerWith1AccessorAttribute
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
