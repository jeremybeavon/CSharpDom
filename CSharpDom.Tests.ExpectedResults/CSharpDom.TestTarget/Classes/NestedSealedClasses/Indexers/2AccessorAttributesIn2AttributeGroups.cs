namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers
{
    public class ClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            public string this[int index]
            {
                [Attribute1]
                [Attribute2]
                get { return default(string); }
                [Attribute1]
                [Attribute2]
                set { }
            }
        }
    }
}
