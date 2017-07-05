namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Fields
{
    public class ClassWithNestedSealedPartialClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
