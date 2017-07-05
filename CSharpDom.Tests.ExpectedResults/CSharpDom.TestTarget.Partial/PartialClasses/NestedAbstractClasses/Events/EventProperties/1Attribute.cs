namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedAbstractClassWithEventPropertyWith1Attribute
    {
        public abstract class Class
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
