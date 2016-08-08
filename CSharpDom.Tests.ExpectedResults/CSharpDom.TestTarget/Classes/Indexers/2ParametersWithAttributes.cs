namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithIndexerWith2ParametersWithAttributes
    {
        public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
        {
            set { }
        }
    }
}
