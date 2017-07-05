namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStructWithPublicEventProperty
    {
        public struct Struct
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
