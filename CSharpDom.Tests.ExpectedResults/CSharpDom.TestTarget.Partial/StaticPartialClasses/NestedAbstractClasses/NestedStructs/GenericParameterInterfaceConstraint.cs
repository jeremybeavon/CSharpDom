namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
