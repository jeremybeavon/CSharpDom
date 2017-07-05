namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedSealedPartialClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
