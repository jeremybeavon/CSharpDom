namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
