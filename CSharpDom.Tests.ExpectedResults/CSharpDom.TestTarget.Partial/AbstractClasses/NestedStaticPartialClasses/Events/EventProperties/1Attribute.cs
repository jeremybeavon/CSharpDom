namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithEventPropertyWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
