namespace CSharpDom.TestTarget.StaticClasses.Events.EventProperties
{
    public static class StaticClassWithEventPropertyWith1AccessorAttribute
    {
        public static event EventHandler Event
        {
            [Attribute1]
            add { }
            [Attribute1]
            remove { }
        }
    }
}
