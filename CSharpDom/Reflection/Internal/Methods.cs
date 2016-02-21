using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Methods<TMethod, TType>
        where TType : ITypeWithReflection
    {
        public Methods(
            TType declaringType,
            Func<TType, MethodInfo, TMethod> methodFactory,
            IDictionary<MethodInfo, Type> interfaceMethods)
        {
            List<TMethod> methods = new List<TMethod>();
            List<AbstractMethodWithReflection> abstractMethods = new List<AbstractMethodWithReflection>();
            List<ConversionOperatorWithReflection> conversionOperators = new List<ConversionOperatorWithReflection>();
            List<OperatorOverloadWithReflection> operatorOverloads = new List<OperatorOverloadWithReflection>();
            List<ExplicitInterfaceMethodWithReflection> explicitInterfaceMethods = new List<ExplicitInterfaceMethodWithReflection>();
            List<ExtensionMethodWithReflection> extensionMethods = new List<ExtensionMethodWithReflection>();
            MethodInfo destructorMethod = new Action(Finalize).Method;
            foreach (MethodInfo method in declaringType.Type.GetAllMethods())
            {
                if (method.GetBaseDefinition() == destructorMethod)
                {
                    Destructor = method;
                }
                else if (method.IsAbstract)
                {
                    abstractMethods.Add(new AbstractMethodWithReflection(declaringType, method));
                }
                else if (!method.IsSpecialName)
                {
                    Type interfaceType;
                    if (method.IsDefined(typeof(ExtensionAttribute)))
                    {
                        extensionMethods.Add(new ExtensionMethodWithReflection(declaringType, method));
                    }
                    else if (interfaceMethods.TryGetValue(method, out interfaceType))
                    {
                        explicitInterfaceMethods.Add(new ExplicitInterfaceMethodWithReflection(declaringType, interfaceType, method));
                    }
                    else
                    {
                        methods.Add(methodFactory(declaringType, method));
                    }
                }
                else if (method.Name == "op_Implicit")
                {
                    conversionOperators.Add(new ConversionOperatorWithReflection(declaringType, method));
                }
                else if (method.Name == "op_Explicit")
                {
                    conversionOperators.Add(new ConversionOperatorWithReflection(declaringType, method));
                }
                else if (method.Name.StartsWith("op_"))
                {
                    operatorOverloads.Add(new OperatorOverloadWithReflection(declaringType, method));
                }
            }

            AbstractMethodsWithReflection = abstractMethods;
            ConversionOperatorsWithReflection = conversionOperators;
            MethodsWithReflection = methods;
            OperatorOverloadsWithReflection = operatorOverloads;
            ExplicitInterfaceMethodsWithReflection = explicitInterfaceMethods;
            ExtensionMethodsWithReflection = extensionMethods;
        }

        public IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperatorsWithReflection { get; private set; }

        public IReadOnlyCollection<AbstractMethodWithReflection> AbstractMethodsWithReflection { get; private set; }

        public IReadOnlyCollection<TMethod> MethodsWithReflection { get; private set; }

        public IReadOnlyCollection<ExtensionMethodWithReflection> ExtensionMethodsWithReflection { get; private set; }

        public IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloadsWithReflection { get; private set; }

        public MethodInfo Destructor { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethodsWithReflection { get; private set; }
    }
}
