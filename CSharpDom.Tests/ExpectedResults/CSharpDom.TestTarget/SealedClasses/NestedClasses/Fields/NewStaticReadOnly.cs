namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Fields
{
    public sealed class SealedClassWithNestedClassWithNewStaticReadOnlyField
    {
        public class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
