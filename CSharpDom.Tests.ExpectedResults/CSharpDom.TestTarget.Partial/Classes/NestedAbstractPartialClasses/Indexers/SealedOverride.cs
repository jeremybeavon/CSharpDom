namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers
{
    public class ClassWithNestedAbstractPartialClassWithSealedOverrideIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public sealed override string this[int index]
            {
                set { }
            }
        }
    }
}
