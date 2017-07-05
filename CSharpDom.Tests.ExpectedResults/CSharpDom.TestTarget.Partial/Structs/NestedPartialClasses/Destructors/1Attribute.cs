namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Destructors
{
    public struct StructWithNestedPartialClassWithDestructorWith1Attribute
    {
        public partial class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
