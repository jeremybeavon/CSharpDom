namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Fields
{
    public partial class PartialClassWithNestedClassWithNewStaticField : BaseClassWithField
    {
        public class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
