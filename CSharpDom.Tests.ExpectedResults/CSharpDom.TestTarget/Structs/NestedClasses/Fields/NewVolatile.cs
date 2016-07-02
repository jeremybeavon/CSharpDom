namespace CSharpDom.TestTarget.Structs.NestedClasses.Fields
{
    public struct StructWithNestedClassWithNewVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
