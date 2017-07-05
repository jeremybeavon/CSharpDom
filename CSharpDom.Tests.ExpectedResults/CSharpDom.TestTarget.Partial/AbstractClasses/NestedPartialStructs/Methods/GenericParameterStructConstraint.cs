namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Methods
{
    public abstract class AbstractClassWithNestedStructWithMethodWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
