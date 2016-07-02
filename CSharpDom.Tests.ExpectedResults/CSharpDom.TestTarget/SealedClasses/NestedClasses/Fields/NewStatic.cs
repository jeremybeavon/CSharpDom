namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields
{
    public sealed class SealedClassWithNestedClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
