namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
