namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
