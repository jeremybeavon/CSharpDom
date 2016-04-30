namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields
{
    public sealed class SealedClassWithNestedClassWithNewStaticVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
