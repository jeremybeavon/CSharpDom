namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Destructors
{
    public struct StructWithNestedAbstractPartialClassWithDestructorWith1Attribute
    {
        public abstract partial class Class
        {
            [Attribute1]
            ~Class()
            {
            }
        }
    }
}
