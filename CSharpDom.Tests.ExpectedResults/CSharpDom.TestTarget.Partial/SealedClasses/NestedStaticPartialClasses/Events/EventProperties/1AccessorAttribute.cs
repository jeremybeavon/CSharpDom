namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticPartialClassWithEventPropertyWith1AccessorAttribute
    {
        public static partial class Class
        {
            public static event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
