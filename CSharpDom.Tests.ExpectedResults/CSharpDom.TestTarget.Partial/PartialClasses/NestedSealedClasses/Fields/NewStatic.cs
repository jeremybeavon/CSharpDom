namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Fields
{
    public partial class PartialClassWithNestedSealedClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
