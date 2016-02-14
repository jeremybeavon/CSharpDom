namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields
{
    public class ClassWithNestedSealedClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
