namespace CSharpDom.TestTarget.Classes
{
    public class ClassWithSealedOverrideIndexer : BaseClassWithIndexer
    {
        public sealed override string this[int index]
        {
            set { }
        }
    }
}
