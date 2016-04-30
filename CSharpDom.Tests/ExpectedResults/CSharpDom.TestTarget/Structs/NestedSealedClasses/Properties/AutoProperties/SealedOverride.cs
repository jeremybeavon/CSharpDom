namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties.AutoProperties
{
    public struct StructWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
