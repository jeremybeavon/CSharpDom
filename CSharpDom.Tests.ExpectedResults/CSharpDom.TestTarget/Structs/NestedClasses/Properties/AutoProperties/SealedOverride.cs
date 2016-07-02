namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties.AutoProperties
{
    public struct StructWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
