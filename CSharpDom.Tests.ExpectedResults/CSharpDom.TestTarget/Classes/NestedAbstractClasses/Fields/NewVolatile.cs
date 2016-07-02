namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields
{
    public class ClassWithNestedAbstractClassWithNewVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
