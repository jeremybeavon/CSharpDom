namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithEventPropertyWith1AccessorAttribute
    {
        public struct Struct
        {
            public event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
