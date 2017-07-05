namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers
{
    public class ClassWithNestedSealedPartialClassWithIndexerWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
