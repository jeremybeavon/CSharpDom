namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
