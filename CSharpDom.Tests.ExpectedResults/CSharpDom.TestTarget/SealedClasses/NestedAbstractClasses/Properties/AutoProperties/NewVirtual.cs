namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithNewVirtualAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
