namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithEventPropertyWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
