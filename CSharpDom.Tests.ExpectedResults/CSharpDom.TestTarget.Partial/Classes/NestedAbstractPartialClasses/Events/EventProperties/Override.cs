namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractPartialClassWithOverrideEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
