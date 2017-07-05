namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedClassWithNewVirtualEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
