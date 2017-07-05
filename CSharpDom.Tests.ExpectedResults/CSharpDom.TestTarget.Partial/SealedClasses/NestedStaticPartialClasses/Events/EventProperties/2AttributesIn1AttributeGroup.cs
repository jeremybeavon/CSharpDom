namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticPartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
