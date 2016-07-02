namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Indexers
{
    public abstract class AbstractClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public string this[int index]
            {
                set { }
            }
        }
    }
}
