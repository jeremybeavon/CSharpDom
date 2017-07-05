namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedClassWithExplicitInterfaceMethodWithParametersWithModifiers
    {
        public class Class : IInterfaceWithMethodWithParametersWithModifiers
        {
            void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
