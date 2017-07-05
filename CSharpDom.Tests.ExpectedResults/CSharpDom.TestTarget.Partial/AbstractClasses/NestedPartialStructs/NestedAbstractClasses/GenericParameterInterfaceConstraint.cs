namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
