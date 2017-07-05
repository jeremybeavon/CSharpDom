namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedPartialClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
