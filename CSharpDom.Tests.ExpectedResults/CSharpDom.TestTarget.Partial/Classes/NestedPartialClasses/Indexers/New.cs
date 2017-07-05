namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers
{
    public class ClassWithNestedPartialClassWithNewIndexer
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
