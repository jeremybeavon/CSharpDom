namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
