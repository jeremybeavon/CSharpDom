namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Indexers
{
    public sealed class SealedClassWithNestedPartialClassWithNewIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public new string this[int index]
            {
                set { }
            }
        }
    }
}
