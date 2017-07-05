namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedPartialClassWithNewAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
