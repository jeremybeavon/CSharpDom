namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute
    {
        public abstract class Class
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
