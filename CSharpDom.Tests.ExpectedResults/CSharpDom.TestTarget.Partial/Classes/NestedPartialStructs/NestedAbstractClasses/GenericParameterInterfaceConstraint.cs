namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterInterfaceConstraint
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
