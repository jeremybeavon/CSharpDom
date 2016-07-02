namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields
{
    public class ClassWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
