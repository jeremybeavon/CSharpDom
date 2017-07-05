namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
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
