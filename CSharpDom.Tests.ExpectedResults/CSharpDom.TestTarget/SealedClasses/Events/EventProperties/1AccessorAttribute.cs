namespace CSharpDom.TestTarget.SealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithEventPropertyWith1AccessorAttribute
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
