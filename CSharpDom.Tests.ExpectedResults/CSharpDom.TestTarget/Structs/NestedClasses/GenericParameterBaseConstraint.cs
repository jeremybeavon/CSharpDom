namespace CSharpDom.TestTarget.Structs.NestedClasses
{
    public struct StructWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
