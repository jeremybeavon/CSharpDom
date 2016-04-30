namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithIndexerWith2Parameters
    {
        public sealed class Class
        {
            public string this[int x, int y]
            {
                set { }
            }
        }
    }
}
