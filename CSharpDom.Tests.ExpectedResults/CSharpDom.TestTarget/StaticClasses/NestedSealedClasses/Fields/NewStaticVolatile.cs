namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields
{
    public static class StaticClassWithNestedSealedClassWithNewStaticVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
