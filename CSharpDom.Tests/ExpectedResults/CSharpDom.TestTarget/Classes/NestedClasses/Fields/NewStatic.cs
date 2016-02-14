namespace CSharpDom.TestTarget.Classes.NestedClasses.Fields
{
    public class ClassWithNestedClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
