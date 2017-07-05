namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Properties.AutoProperties
{
    public sealed partial class SealedPartialClassWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
