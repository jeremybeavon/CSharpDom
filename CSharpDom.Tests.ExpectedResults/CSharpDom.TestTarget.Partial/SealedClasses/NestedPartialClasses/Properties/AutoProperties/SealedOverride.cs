namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedPartialClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
