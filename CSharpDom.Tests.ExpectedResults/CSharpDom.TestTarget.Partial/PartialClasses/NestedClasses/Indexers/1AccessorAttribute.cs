namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Indexers
{
    public partial class PartialClassWithNestedClassWithIndexerWith1AccessorAttribute
    {
        public class Class
        {
            public string this[int index]
            {
                [Attribute1]
                get { return default(string); }
                [Attribute1]
                set { }
            }
        }
    }
}
