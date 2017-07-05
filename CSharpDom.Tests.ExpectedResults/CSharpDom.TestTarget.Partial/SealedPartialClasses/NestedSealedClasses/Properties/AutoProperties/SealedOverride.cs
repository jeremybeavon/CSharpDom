namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
