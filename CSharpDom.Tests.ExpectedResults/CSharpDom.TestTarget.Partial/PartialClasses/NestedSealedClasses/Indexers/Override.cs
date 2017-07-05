namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers
{
    public partial class PartialClassWithNestedSealedClassWithOverrideIndexer
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
