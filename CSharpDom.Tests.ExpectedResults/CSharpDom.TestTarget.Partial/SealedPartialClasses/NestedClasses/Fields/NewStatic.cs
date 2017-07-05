namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Fields
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
