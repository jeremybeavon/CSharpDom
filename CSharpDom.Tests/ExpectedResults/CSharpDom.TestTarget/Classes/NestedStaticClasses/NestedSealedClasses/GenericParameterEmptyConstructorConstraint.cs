﻿namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
