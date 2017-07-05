namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
