namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods
{
    public class ClassWithNestedSealedPartialClassWithMethodWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public T Method<T>()
                where T : struct
            {
                return default(T);
            }
        }
    }
}
