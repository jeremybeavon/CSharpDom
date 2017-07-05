namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Fields
{
    public partial struct PartialStructWithWithNestedClassWithNewVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
