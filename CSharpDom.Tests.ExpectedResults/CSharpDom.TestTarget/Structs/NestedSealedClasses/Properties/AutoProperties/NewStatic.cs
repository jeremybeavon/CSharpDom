namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties
{
    public struct StructWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
