namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedSealedClassWithOverrideIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
