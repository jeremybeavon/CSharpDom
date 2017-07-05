namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
