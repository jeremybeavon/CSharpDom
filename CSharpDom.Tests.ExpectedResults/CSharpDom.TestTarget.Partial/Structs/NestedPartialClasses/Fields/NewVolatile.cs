namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Fields
{
    public struct StructWithNestedPartialClassWithNewVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new volatile int Field;
        }
    }
}
