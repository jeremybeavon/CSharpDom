namespace CSharpDom.TestTarget.StaticClasses.Events.EventProperties
{
    public static class StaticClassWithEventPropertyWith1Attribute
    {
        [Attribute1]
        public static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
