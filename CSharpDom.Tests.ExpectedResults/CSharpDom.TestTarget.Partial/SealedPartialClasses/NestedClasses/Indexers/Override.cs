namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithOverrideIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public override string this[int index]
            {
                set { }
            }
        }
    }
}
