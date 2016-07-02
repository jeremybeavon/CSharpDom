namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
