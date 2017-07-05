namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Indexers
{
    public class ClassWithNestedSealedPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public sealed partial class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
