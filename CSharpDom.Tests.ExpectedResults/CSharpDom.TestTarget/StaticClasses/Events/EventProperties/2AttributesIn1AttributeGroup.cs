namespace CSharpDom.TestTarget.StaticClasses.Events.EventProperties
{
    public static class StaticClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
