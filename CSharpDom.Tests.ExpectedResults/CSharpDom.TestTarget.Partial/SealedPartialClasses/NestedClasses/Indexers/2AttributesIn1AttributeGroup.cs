namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Indexers
{
    public sealed partial class SealedPartialClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup
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
