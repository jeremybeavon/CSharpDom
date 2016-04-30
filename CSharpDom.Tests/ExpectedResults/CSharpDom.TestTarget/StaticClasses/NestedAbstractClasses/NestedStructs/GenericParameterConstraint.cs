namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStructs
{
    public static class StaticClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
