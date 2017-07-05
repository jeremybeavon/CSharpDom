namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Properties.AutoProperties
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
