namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedClasses
{
    public struct StructWithNestedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
