namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Fields
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNewStaticField : BaseClassWithField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
