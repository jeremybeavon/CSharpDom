namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Indexers
{
    public abstract partial class AbstractPartialClassWithNestedClassWithIndexerWith1Attribute
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
