namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Fields
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
