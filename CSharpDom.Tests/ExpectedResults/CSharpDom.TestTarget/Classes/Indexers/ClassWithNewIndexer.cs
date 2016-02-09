namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithNewIndexer : BaseClassWithIndexer
    {
        public new string this[int index]
        {
            set { }
        }
    }
}
