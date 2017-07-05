namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithEventPropertyWith1Attribute
    {
        [Attribute1]
        public static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
