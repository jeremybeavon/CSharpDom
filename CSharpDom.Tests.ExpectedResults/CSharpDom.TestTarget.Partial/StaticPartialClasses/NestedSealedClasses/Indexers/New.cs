namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNewIndexer
    {
        public sealed class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
