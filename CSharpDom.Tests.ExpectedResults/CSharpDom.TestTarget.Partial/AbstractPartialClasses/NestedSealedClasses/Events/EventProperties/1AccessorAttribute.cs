namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute
    {
        public sealed class Class
        {
            public event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
