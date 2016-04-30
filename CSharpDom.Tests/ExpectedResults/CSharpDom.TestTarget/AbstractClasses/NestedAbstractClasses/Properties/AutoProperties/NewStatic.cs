namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
