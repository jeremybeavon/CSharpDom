namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers
{
    public abstract class AbstractClassWithNestedClassWithVirtualIndexer
    {
        public class Class
        {
            public virtual string this[int index]
            {
                set { }
            }
        }
    }
}
