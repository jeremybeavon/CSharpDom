namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Indexers
{
    public abstract class AbstractClassWithNestedAbstractClassWithIndexerWith1Attribute
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
