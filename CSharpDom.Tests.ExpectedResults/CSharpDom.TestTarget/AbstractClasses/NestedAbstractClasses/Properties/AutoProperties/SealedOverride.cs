namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
