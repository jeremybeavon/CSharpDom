namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Properties.AutoProperties
{
    public partial class PartialClassWithNestedSealedClassWithNewStaticAutoProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
