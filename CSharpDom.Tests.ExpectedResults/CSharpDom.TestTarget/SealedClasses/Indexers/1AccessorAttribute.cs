namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithIndexerWith1AccessorAttribute
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
