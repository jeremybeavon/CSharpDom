namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractPartialClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
