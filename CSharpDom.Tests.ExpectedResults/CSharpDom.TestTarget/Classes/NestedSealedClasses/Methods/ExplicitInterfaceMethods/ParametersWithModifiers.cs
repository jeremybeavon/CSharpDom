﻿namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods.ExplicitInterfaceMethods
{
    public class ClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers
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
