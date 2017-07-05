namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedPartialClassWithEventPropertyWithGenericDelegate
    {
        public sealed partial class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
