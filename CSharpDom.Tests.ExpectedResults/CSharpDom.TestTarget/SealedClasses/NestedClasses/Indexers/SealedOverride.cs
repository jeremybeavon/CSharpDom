namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithSealedOverrideIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
