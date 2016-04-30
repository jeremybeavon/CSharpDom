namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields
{
    public static class StaticClassWithNestedSealedClassWithNewStaticReadOnlyField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
