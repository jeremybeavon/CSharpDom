namespace CSharpDom.TestTarget.Classes.Indexers
{
    public class ClassWithSealedOverrideIndexer : BaseClassWithIndexer
    {
        public sealed override string this[int index]
        {
            set { }
        }
    }
}
