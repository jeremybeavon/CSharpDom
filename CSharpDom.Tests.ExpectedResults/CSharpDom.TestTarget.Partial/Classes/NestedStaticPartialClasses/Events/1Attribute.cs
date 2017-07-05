namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Events
{
    public class ClassWithNestedStaticPartialClassWithEventWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
