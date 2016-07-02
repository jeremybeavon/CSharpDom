namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
