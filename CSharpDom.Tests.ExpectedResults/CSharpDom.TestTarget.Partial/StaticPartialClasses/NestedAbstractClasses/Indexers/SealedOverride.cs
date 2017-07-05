namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithSealedOverrideIndexer
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
