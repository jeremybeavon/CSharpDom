namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Fields
{
    public class ClassWithNestedAbstractPartialClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
