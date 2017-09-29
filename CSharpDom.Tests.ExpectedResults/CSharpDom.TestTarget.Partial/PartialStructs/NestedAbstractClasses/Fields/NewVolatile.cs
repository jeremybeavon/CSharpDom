namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Fields
{
    public partial struct PartialStructWithNestedAbstractClassWithNewVolatileField
    {
        public abstract class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
