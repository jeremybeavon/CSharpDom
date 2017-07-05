namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractPartialClassWithPrivateEventProperty
    {
        public abstract partial class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
