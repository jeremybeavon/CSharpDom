namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Fields
{
    public static class StaticClassWithNestedAbstractClassWithNewVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
