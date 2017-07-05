namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedSealedPartialClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
