namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.Events.EventProperties
{
    public struct StructWithNestedStaticPartialClassWithEventPropertyWithGenericDelegate
    {
        public static partial class Class
        {
            public static event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
