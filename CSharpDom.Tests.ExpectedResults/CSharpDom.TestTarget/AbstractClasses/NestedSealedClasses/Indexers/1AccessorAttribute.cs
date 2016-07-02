namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithIndexerWith1AccessorAttribute
    {
        public sealed class Class
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
