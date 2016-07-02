namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Indexers
{
    public sealed class SealedClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
