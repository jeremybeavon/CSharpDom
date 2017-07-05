namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Properties.AutoProperties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
