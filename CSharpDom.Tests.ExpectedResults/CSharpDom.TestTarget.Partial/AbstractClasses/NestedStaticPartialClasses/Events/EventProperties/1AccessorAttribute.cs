namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithEventPropertyWith1AccessorAttribute
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
