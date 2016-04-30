namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields
{
    public struct StructWithNestedSealedClassWithNewStaticField
    {
        public sealed class Class : BaseClassWithField
        {
            public new static string Field;
        }
    }
}
