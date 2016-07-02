namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedClassWithEventPropertyWithGenericDelegate
    {
        public sealed class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
