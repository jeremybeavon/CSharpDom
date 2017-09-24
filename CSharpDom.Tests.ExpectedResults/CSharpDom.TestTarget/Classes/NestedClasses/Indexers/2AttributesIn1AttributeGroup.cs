namespace CSharpDom.TestTarget.Classes.NestedClasses.Indexers
{
    public class ClassWithNestedClassWithIndexerWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
