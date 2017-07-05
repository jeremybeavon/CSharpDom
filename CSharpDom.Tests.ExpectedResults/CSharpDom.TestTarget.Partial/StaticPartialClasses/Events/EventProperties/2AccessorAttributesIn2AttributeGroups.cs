namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
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
