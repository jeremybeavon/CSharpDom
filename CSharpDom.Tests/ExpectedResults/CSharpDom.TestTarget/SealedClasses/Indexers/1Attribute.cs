namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithIndexerWith1Attribute
    {
        [Attribute1]
        public string this[int index]
        {
            set { }
        }
    }
}
