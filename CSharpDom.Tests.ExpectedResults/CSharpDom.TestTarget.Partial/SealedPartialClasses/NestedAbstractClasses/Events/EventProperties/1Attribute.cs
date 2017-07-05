namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithEventPropertyWith1Attribute
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
