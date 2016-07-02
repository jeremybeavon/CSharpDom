namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
