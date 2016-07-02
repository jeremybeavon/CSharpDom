namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties
{
    public struct StructWithNestedClassWithNewStaticEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
