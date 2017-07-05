namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
