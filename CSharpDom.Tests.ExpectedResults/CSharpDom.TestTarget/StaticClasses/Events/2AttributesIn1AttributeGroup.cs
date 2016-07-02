namespace CSharpDom.TestTarget.StaticClasses.Events
{
    public static class StaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static event EventHandler Event;
    }
}
