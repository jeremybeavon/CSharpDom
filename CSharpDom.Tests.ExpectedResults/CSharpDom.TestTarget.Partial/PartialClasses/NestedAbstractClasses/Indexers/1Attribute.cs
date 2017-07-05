namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Indexers
{
    public partial class PartialClassWithNestedAbstractClassWithIndexerWith1Attribute
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
