namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
