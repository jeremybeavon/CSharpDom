namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Fields
{
    public class ClassWithNestedSealedPartialClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
