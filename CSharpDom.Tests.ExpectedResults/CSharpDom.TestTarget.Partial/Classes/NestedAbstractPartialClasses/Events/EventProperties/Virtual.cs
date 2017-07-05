namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractPartialClassWithVirtualEventProperty
    {
        public abstract partial class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
