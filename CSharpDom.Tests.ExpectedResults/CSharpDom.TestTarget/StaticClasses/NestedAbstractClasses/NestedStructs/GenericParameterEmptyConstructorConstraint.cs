namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStructs
{
    public static class StaticClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
