namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Fields
{
    public partial struct PartialStructWithNestedClassWithNewStaticReadOnlyField
    {
        public class Class : BaseClassWithField
        {
            public new static readonly int Field;
        }
    }
}
