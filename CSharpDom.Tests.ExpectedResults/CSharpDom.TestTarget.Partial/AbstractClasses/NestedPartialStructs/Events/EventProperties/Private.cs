namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStructWithPrivateEventProperty
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
