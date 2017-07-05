namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
