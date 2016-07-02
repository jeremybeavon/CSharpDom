namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithIndexerWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
