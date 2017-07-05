namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticPartialClassWithEventPropertyWith1Attribute
    {
        public static partial class Class
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
