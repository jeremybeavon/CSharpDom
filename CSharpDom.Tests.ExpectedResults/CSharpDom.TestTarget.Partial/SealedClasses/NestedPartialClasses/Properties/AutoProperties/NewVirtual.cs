namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedPartialClassWithNewVirtualAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
