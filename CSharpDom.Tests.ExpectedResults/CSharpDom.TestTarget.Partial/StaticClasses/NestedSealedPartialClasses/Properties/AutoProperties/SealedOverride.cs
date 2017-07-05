namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedSealedPartialClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
