namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedDelegateWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
