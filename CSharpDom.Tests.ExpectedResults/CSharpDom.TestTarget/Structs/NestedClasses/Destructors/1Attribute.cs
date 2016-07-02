namespace CSharpDom.TestTarget.Structs.NestedClasses.Destructors
{
    public struct StructWithNestedClassWithDestructorWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
