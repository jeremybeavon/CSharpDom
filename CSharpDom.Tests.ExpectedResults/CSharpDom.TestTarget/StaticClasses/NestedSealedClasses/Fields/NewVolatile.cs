namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields
{
    public static class StaticClassWithNestedSealedClassWithNewVolatileField
    {
        public sealed class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
