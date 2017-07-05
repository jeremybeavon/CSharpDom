namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithPrivateEventProperty
    {
        public struct Struct
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
