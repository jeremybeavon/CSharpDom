namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Fields
{
    public partial struct PartialStructWithNestedClassWithNewVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
