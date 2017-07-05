namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers
{
    public partial class PartialClassWithNestedSealedClassWithNewIndexer
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
