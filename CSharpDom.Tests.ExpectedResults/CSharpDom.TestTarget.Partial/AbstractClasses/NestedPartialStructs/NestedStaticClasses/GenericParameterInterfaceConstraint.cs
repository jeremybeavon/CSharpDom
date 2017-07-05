namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
