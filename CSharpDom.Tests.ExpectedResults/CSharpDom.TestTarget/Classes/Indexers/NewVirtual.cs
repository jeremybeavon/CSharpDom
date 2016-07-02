namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithNewVirtualIndexer : BaseClassWithIndexer
    {
        public new virtual string this[int index]
        {
            set { }
        }
    }
}
