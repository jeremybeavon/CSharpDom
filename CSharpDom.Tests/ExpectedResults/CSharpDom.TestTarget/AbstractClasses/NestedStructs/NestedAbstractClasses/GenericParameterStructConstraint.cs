namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
