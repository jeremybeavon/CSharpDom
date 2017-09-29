namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Fields
{
    public partial struct PartialStructWithNestedClassWithNewStaticVolatileField
    {
        public class Class : BaseClassWithField
        {
            public new static volatile int Field;
        }
    }
}
