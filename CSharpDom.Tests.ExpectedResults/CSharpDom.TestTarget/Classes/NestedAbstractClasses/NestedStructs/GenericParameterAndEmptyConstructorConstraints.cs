namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStructs
{
    public class ClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
