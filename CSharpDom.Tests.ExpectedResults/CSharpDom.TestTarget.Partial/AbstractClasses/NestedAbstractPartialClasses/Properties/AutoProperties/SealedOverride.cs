namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithSealedOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
