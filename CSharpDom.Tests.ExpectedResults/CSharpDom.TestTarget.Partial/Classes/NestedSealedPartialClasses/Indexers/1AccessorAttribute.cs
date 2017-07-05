namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers
{
    public class ClassWithNestedSealedPartialClassWithIndexerWith1AccessorAttribute
    {
        public sealed partial class Class
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
