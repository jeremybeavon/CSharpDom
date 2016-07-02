namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields
{
    public abstract class AbstractClassWithNestedClassWithNewVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
