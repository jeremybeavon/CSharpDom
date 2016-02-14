namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields
{
    public class ClassWithNestedAbstractClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
