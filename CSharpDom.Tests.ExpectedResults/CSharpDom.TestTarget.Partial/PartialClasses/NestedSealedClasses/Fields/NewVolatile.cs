namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Fields
{
    public partial class PartialClassWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
