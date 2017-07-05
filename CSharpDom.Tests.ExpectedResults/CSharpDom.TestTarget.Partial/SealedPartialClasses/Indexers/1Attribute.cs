namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.Indexers
{
    public sealed partial class SealedPartialClassWithIndexerWith1Attribute
    {
        [Attribute1]
        public string this[int index]
        {
            set { }
        }
    }
}
