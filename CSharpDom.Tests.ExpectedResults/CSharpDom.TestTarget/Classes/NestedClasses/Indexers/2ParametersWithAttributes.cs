namespace CSharpDom.TestTarget.Classes.NestedClasses.Indexers
{
    public class ClassWithNestedClassWithIndexerWith2ParametersWithParameters
    {
        public class Class
        {
            public string this[[Attribute1]int x, [Attribute2][Attribute3]int y]
            {
                set { }
            }
        }
    }
}
