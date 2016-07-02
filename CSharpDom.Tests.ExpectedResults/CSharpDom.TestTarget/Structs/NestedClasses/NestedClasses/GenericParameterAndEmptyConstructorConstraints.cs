namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedClasses
{
    public struct StructWithNestedClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
