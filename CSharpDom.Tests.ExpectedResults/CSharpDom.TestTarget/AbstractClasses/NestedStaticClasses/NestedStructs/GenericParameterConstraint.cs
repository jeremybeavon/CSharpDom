namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
