namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Indexers
{
    public partial class PartialClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
