namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Events
{
    public static partial class StaticPartialClassWithNestedSealedClassWithEventWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
