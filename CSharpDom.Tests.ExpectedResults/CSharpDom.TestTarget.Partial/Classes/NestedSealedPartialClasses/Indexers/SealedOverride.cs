namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers
{
    public class ClassWithNestedSealedPartialClassWithSealedOverrideIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
