namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers
{
    public abstract class AbstractClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup
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
