namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers
{
    public class ClassWithNestedAbstractClassWithSealedOverrideIndexer
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
