namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Destructors
{
    public struct StructWithNestedSealedPartialClassWithDestructorWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
