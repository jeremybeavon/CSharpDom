namespace CSharpDom.TestTarget.Classes.NestedClasses.Indexers
{
    public class ClassWithNestedClassWithNewIndexer
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
