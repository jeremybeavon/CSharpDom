namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events.EventProperties
{
    public class ClassWithNestedStructWithEventPropertyWith1AccessorAttribute
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
