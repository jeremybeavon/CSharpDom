namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
