namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields
{
    public class ClassWithNestedSealedClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
