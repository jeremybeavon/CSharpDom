namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStructWithEventPropertyWith1AccessorAttribute
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
