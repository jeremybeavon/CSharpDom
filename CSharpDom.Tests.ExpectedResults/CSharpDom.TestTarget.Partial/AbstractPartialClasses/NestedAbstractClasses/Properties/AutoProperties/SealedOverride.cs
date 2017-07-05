namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
