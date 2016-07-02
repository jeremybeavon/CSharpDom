namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers
{
    public abstract class AbstractClassWithNestedClassWithIndexerWith1AccessorAttribute
    {
        public class Class
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
