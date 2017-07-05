namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods
{
    public abstract class AbstractClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
