namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields
{
    public struct StructWithNestedAbstractClassWithNewStaticVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
