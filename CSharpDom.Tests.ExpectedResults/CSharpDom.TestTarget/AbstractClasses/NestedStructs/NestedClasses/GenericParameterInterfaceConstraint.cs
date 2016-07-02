namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint
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
