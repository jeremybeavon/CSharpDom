namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public static class Class
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
