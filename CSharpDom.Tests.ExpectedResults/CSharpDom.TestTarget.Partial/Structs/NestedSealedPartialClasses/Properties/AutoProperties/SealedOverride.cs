namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedSealedPartialClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
