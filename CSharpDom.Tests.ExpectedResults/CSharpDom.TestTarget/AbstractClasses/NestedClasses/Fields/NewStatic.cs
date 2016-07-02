namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields
{
    public abstract class AbstractClassWithNestedClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
