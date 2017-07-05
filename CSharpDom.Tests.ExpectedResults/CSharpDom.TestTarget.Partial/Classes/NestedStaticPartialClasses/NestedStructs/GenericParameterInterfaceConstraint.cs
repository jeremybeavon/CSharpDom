namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStructs
{
    public class ClassWithNestedStaticPartialClassWithNestedStructWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public struct NestedStruct<T>
                where T : IInterface
            {
            }
        }
    }
}
