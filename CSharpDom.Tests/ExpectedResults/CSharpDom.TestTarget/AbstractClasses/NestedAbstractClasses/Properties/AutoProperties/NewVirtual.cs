namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewVirtualAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
