namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Fields
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
