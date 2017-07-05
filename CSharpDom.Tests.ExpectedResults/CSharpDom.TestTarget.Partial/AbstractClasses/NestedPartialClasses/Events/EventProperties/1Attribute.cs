namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithEventPropertyWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
