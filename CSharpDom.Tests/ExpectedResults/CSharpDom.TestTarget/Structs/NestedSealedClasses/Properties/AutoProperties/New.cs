namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties
{
    public struct StructWithNestedSealedClassWithNewAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
