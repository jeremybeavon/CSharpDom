namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedAbstractClasses
{
    public struct StructWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
