namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Indexers
{
    public class ClassWithNestedAbstractPartialClassWithIndexerWith2ParametersWithAttributes
    {
        public abstract partial class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
