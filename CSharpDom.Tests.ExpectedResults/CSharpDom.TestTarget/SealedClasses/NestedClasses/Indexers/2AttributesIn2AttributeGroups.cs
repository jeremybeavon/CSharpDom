namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers
{
    public sealed class SealedClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups
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
