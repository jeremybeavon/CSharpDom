namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Fields
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
