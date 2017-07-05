namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Destructors
{
    public struct StructWithNestedAbstractPartialClassWithDestructorWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            ~Class()
            {
            }
        }
    }
}
