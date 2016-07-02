namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
