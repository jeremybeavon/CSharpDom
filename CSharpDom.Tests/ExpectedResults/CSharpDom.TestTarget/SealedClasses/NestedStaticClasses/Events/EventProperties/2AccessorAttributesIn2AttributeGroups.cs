namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Constructors
{
    public sealed class SealedClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public static class Class
        {
            public static event EventHandler Event
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
