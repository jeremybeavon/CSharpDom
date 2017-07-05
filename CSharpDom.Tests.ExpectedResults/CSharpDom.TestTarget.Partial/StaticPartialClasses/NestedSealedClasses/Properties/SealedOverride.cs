namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Properties
{
    public static partial class StaticPartialClassWithNestedSealedClassWithSealedOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
