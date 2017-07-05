namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
