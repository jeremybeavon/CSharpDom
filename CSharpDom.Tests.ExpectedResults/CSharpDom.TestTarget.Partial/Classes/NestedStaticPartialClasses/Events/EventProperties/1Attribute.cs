namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Events.EventProperties
{
    public class ClassWithNestedStaticPartialClassWithEventPropertyWith1Attribute
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
