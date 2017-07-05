namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNewVirtualAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property { get; set; }
        }
    }
}
