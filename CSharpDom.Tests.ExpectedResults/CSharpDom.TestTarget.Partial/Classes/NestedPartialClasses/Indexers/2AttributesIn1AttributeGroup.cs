namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers
{
    public class ClassWithNestedPartialClassWithIndexerWithWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
