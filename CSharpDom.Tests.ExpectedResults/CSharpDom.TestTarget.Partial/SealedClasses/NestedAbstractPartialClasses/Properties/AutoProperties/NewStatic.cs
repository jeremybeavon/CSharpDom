namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
