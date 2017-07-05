namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithEventPropertyWith1AccessorAttribute
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
