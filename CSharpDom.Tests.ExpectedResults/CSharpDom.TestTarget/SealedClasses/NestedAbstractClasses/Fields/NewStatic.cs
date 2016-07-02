namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields
{
    public sealed class SealedClassWithNestedAbstractClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
