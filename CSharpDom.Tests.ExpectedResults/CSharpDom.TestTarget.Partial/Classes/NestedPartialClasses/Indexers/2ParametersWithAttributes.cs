namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Indexers
{
    public class ClassWithNestedPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public partial class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
