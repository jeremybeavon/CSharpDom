namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
