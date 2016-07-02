namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Constructors
{
    public abstract class AbstractClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public static class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
