namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractClassWithStaticEventProperty
    {
        public abstract class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
