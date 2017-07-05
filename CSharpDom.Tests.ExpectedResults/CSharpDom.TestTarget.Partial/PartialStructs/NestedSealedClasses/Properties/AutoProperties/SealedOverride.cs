namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
