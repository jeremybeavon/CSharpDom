namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields
{
    public sealed class SealedClassWithNestedClassWithNewVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
