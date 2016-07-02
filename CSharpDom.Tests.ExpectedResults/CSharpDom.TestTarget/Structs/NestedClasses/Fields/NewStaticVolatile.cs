namespace CSharpDom.TestTarget.Structs.NestedClasses.Fields
{
    public struct StructWithNestedClassWithNewStaticVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
