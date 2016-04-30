namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers
{
    public abstract class AbstractClassWithNestedClassWithProtectedIndexer
    {
        public class Class
        {
            protected string this[int index]
            {
                set { }
            }
        }
    }
}
