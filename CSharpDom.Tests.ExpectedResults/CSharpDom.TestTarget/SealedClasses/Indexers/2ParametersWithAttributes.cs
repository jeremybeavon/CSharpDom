namespace CSharpDom.TestTarget.SealedClasses.Indexers
{
    public sealed class SealedClassWithIndexerWith2ParametersWithParameters
    {
        public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
