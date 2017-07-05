namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers
{
    public partial class PartialClassWithNestedClassWithIndexerWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
