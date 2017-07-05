namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedPartialClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
