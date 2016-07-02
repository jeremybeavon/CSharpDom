namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields
{
    public struct StructWithNestedAbstractClassWithNewVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
