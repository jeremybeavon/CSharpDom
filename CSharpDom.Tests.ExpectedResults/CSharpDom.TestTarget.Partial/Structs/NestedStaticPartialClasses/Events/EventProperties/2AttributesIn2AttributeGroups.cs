namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events.EventProperties
{
    public struct StructWithNestedStaticPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public static partial class Class
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
