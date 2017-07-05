namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public partial class PartialClassWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
