namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Fields
{
    public sealed class SealedClassWithNestedPartialClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
