namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithIndexerWith1Attribute
    {
        [Attribute1]
        public string this[int index]
        {
            set { }
        }
    }
}
