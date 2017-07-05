namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
