namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
