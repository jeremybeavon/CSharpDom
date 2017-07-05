namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Events
{
    public sealed class SealedClassWithNestedStaticPartialClassWithEventWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public static event EventHandler Event;
        }
    }
}
