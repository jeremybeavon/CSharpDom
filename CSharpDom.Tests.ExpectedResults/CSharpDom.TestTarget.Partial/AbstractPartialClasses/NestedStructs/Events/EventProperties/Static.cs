namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithStaticEventProperty
    {
        public struct Struct
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
