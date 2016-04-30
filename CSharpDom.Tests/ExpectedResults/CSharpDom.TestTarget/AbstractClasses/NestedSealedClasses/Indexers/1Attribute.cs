namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Indexers
{
    public abstract class AbstractClassWithNestedSealedClassWithIndexerWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
