namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithEventPropertyWith1Attribute
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
