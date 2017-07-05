namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Fields
{
    public struct StructWithNestedAbstractPartialClassWithNewVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
