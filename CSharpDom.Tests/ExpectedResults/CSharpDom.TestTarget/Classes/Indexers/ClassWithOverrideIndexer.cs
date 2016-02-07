namespace CSharpDom.TestTarget.Classes
{
    public class ClassWithOverrideIndexer : BaseClassWithIndexer
    {
        public override string this[int index]
        {
            set { }
        }
    }
}
