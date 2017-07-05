namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedPartialClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
