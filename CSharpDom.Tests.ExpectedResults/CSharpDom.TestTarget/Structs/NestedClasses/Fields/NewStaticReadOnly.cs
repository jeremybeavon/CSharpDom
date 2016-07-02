namespace CSharpDom.TestTarget.Structs.NestedClasses.Fields
{
    public struct StructWithNestedClassWithNewStaticReadOnlyField
    {
        public class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
