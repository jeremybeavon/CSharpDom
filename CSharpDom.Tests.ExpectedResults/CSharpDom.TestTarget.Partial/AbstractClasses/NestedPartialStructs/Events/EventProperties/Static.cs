namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStructWithStaticEventProperty
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
