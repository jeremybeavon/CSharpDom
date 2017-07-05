namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
