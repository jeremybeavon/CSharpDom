namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            public event EventHandler Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
