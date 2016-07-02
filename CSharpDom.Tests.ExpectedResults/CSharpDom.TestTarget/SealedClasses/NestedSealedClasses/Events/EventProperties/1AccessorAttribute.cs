namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute
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
