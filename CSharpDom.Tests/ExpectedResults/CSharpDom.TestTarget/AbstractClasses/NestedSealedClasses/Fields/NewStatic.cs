namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields
{
    public abstract class AbstractClassWithNestedSealedClassWithNewStaticField : BaseClassWithField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
