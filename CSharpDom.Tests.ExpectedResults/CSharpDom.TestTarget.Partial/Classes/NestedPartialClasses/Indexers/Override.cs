namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers
{
    public class ClassWithNestedPartialClassWithOverrideIndexer
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
