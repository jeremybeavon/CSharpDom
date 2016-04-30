namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStructs
{
    public static class StaticClassWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
