namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedPartialClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
