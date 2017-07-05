namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers
    {
        public sealed class Class : IInterfaceWithMethodWithParametersWithModifiers
        {
            void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
