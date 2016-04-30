namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers
{
    public abstract class AbstractClassWithNestedClassWithInternalIndexer
    {
        public class Class
        {
            internal string this[int index]
            {
                set { }
            }
        }
    }
}
