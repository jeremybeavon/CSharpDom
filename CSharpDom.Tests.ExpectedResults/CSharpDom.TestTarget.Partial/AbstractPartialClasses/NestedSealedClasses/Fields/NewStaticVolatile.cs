namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Fields
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
