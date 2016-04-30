namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
