namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Indexers
{
    public static partial class StaticPartialClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups
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
