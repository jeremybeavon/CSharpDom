namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers
{
    public class ClassWithNestedPartialClassWithSealedOverrideIndexer
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
