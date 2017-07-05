namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
