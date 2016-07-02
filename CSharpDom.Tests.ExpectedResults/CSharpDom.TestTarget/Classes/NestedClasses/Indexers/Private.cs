namespace CSharpDom.TestTarget.Classes.NestedClasses.Indexers
{
    public class ClassWithNestedClassWithPrivateIndexer
    {
        public class Class
        {
            private string this[int index]
            {
                set { }
            }
        }
    }
}
