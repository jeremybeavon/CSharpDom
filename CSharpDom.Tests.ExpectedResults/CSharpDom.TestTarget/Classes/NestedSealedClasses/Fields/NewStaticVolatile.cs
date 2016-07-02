namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields
{
    public class ClassWithNestedSealedClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
