namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
