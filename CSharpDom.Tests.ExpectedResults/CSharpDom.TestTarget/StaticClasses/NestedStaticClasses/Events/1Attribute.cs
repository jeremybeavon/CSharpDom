namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events
{
    public static class StaticClassWithNestedStaticClassWithEventWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
