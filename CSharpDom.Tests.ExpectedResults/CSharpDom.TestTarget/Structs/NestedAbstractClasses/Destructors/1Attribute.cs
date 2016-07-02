namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Destructors
{
    public struct StructWithNestedAbstractClassWithDestructorWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
