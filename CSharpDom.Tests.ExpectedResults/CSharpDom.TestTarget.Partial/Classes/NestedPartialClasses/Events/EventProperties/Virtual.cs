namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedPartialClassWithVirtualEventProperty
    {
        public partial class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
