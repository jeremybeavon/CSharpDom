namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
