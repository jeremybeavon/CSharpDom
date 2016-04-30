namespace CSharpDom.TestTarget.StaticClasses.Constructors
{
    public static class StaticClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
