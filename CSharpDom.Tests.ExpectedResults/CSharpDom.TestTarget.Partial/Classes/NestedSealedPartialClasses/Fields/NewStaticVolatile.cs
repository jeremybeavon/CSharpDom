namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Fields
{
    public class ClassWithNestedSealedPartialClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
