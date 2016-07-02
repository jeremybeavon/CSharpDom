namespace CSharpDom.TestTarget.AbstractClasses.Indexers
{
    public abstract class AbstractClassWithIndexerWith2ParametersWithParameters
    {
        public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
