namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Constructors
{
    public static class StaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
