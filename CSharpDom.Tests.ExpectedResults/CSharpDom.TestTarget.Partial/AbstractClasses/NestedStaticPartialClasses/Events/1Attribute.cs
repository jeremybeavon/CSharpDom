namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Events
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithEventWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
