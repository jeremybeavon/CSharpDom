namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Fields
{
    public partial class PartialClassWithNestedAbstractClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
