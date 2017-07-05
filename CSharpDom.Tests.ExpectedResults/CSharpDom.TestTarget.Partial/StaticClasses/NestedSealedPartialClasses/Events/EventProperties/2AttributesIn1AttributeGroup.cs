namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedSealedPartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
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
