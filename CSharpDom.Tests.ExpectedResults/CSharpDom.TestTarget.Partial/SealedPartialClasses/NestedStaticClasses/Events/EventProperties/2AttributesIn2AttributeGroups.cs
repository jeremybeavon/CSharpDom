namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public static class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
