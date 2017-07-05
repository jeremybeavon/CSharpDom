namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
