namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticClassWithEventPropertyWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
