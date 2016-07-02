namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields
{
    public struct StructWithNestedAbstractClassWithNewStaticReadOnlyField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
