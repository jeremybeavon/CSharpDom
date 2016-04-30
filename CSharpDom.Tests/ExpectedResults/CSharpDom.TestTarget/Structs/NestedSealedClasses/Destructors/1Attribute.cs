namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Destructors
{
    public struct StructWithNestedSealedClassWithDestructorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
