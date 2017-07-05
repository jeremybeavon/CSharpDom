namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public partial class PartialClassWithNestedSealedClassWithSealedOverrideAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
