namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
