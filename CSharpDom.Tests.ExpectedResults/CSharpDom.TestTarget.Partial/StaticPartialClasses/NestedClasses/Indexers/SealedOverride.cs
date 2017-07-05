namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedClassWithSealedOverrideIndexer
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
