namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Events.EventProperties
{
    public class ClassWithNestedStaticPartialClassWithEventPropertyWithGenericDelegate
    {
        public static partial class Class
        {
            public static event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
