namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedClassWithOverrideEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
