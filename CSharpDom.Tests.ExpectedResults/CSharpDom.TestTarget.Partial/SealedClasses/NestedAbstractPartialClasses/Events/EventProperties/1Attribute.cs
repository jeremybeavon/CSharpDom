namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithEventPropertyWith1Attribute
    {
        public abstract partial class Class
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
