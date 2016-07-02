namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties
{
    public struct StructWithNestedClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
