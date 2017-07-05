namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
