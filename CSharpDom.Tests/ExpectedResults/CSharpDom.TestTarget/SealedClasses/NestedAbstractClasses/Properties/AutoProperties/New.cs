namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Properties.AutoProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithNewAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
