namespace CSharpDom.TestTarget.Structs.NestedClasses
{
    public struct StructWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
