namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithOverrideIndexer
    {
        public abstract class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
