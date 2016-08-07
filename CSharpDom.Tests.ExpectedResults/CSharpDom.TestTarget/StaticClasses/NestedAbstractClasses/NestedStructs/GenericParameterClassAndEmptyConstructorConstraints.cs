namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStructs
{
    public static class StaticClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
