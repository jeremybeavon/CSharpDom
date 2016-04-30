namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers
{
    public abstract class AbstractClassWithNestedClassWithPrivateIndexer
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
