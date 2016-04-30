namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties
{
    public struct StructWithNestedSealedClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
