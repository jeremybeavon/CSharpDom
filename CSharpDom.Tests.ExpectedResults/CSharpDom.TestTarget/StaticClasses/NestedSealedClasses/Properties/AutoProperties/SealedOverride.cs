namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties.AutoProperties
{
    public static class StaticClassWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
