namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
