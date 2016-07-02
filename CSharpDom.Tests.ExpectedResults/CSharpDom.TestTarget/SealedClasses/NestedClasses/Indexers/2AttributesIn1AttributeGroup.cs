namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
