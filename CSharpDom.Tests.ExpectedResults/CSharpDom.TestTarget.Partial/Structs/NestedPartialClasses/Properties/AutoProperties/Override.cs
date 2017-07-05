namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedPartialClassWithOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
