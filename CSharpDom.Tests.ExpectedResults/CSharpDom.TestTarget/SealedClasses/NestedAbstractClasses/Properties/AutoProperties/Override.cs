namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
