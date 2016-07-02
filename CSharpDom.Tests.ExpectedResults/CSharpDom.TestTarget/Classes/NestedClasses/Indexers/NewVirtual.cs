namespace CSharpDom.TestTarget.Classes.NestedClasses.Indexers
{
    public class ClassWithNestedClassWithNewVirtualIndexer
    {
        public class Class : BaseClassWithIndexer
        {
            public new virtual string this[int index]
            {
                set { }
            }
        }
    }
}
