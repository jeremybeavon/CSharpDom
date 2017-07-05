namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Methods.ExplicitInterfaceMethods
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiers
    {
        public abstract class Class : IInterfaceWithMethodWithParametersWithModifiers
        {
            void IInterfaceWithMethodWithParametersWithModifiers.Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
