namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields
{
    public sealed class SealedClassWithNestedAbstractClassWithNewVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
