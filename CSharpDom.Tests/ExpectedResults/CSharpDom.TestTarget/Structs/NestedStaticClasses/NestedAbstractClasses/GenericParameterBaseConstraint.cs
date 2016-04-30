namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
