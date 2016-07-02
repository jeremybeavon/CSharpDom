namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
