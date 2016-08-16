using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class Methods<TConstructor, TMethod, TType>
        where TType : ITypeWithCodeAnalysis
    {
        public Methods(
            TType declaringType,
            Func<TType, MethodDefinition, TConstructor> constructorFactory,
            Func<TType, MethodDefinition, TMethod> methodFactory)
        {
            List<TConstructor> constructors = new List<TConstructor>();
            List<TMethod> methods = new List<TMethod>();
            List<AbstractMethodWithCodeAnalysis> abstractMethods = new List<AbstractMethodWithCodeAnalysis>();
            List<ConversionOperatorWithCodeAnalysis> conversionOperators = new List<ConversionOperatorWithCodeAnalysis>();
            List<OperatorOverloadWithCodeAnalysis> operatorOverloads = new List<OperatorOverloadWithCodeAnalysis>();
            List<ExplicitInterfaceMethodWithCodeAnalysis> explicitInterfaceMethods = new List<ExplicitInterfaceMethodWithCodeAnalysis>();
            List<ExtensionMethodWithCodeAnalysis> extensionMethods = new List<ExtensionMethodWithCodeAnalysis>();
            foreach (MethodDefinition method in declaringType.TypeDefinition.Methods)
            {
                if (method.Name == "Finalize" && method.Overrides.Count != 0 && method.Parameters.Count == 0)
                {
                    Destructor = method;
                }
                else if (method.IsAbstract)
                {
                    abstractMethods.Add(new AbstractMethodWithCodeAnalysis(declaringType, method));
                }
                else if (!method.IsSpecialName)
                {
                    if (method.IsDefined(declaringType.Assembly, typeof(ExtensionAttribute)))
                    {
                        extensionMethods.Add(new ExtensionMethodWithCodeAnalysis(declaringType, method));
                    }
                    else if (method.Name.Contains("."))
                    {
                        explicitInterfaceMethods.Add(new ExplicitInterfaceMethodWithCodeAnalysis(declaringType, method));
                    }
                    else
                    {
                        methods.Add(methodFactory(declaringType, method));
                    }
                }
                else if (method.Name == ".ctor")
                {
                    constructors.Add(constructorFactory(declaringType, method));
                }
                else if (method.Name == ".cctor")
                {
                    StaticConstructorWithCodeAnalysis = new StaticConstructorWithCodeAnalysis(declaringType, method);
                }
                else if (method.Name == "op_Implicit")
                {
                    conversionOperators.Add(new ConversionOperatorWithCodeAnalysis(declaringType, method));
                }
                else if (method.Name == "op_Explicit")
                {
                    conversionOperators.Add(new ConversionOperatorWithCodeAnalysis(declaringType, method));
                }
                else if (method.Name.StartsWith("op_"))
                {
                    operatorOverloads.Add(new OperatorOverloadWithCodeAnalysis(declaringType, method));
                }
            }

            ConstructorsWithCodeAnalysis = constructors;
            AbstractMethodsWithCodeAnalysis = abstractMethods;
            ConversionOperatorsWithCodeAnalysis = conversionOperators;
            MethodsWithCodeAnalysis = methods;
            OperatorOverloadsWithCodeAnalysis = operatorOverloads;
            ExplicitInterfaceMethodsWithCodeAnalysis = explicitInterfaceMethods;
            ExtensionMethodsWithCodeAnalysis = extensionMethods;
        }

        public IReadOnlyCollection<TConstructor> ConstructorsWithCodeAnalysis { get; private set; }

        public StaticConstructorWithCodeAnalysis StaticConstructorWithCodeAnalysis { get; set; }

        public IReadOnlyCollection<ConversionOperatorWithCodeAnalysis> ConversionOperatorsWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<AbstractMethodWithCodeAnalysis> AbstractMethodsWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<TMethod> MethodsWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<ExtensionMethodWithCodeAnalysis> ExtensionMethodsWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<OperatorOverloadWithCodeAnalysis> OperatorOverloadsWithCodeAnalysis { get; private set; }

        public MethodDefinition Destructor { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethodsWithCodeAnalysis { get; private set; }
    }
}
