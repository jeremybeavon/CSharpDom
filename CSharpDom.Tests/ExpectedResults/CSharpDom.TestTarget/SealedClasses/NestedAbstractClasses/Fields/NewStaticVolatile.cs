namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields
{
    public sealed class SealedClassWithNestedAbstractClassWithNewStaticVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
