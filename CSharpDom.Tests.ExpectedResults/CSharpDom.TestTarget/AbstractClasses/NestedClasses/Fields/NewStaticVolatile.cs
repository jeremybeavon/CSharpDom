namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields
{
    public abstract class AbstractClassWithNestedClassWithNewStaticVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
