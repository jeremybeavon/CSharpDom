namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedSealedPartialClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
