namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Fields
{
    public class ClassWithNestedSealedPartialClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
