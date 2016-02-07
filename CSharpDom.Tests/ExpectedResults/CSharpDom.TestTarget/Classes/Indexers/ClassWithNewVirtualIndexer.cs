namespace CSharpDom.TestTarget.Classes
{
    public class ClassWithNewVirtualIndexer : BaseClassWithIndexer
    {
        public new virtual string this[int index]
        {
            set { }
        }
    }
}
