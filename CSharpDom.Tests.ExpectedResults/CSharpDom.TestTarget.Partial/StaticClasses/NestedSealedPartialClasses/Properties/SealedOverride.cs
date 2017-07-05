namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Properties
{
    public static class StaticClassWithNestedSealedPartialClassWithSealedOverrideProperty
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
