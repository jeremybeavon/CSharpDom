namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedAbstractClasses
{
    public struct StructWithNestedClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
