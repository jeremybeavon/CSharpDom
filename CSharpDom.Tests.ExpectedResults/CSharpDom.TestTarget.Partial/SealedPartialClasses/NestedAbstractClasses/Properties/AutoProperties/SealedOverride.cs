namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
