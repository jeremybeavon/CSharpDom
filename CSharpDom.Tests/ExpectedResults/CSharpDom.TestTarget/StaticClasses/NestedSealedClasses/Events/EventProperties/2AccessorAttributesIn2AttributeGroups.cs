namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Constructors
{
    public static class StaticClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            public event EventHandler Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
