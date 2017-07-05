namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Events.EventProperties
{
    public class ClassWithNestedStaticPartialClassWithEventPropertyWith1AccessorAttribute
    {
        public static partial class Class
        {
            public static event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
