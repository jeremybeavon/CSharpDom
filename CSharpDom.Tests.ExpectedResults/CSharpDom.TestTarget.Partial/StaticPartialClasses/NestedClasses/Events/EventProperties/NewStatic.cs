namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedClassWithNewStaticEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
