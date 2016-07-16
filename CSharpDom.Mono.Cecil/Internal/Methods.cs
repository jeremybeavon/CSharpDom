using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Methods<TConstructor, TMethod, TType>
        where TType : ITypeWithMonoCecil
    {
        public Methods(
            TType declaringType,
            Func<TType, MethodDefinition, TConstructor> constructorFactory,
            Func<TType, MethodDefinition, TMethod> methodFactory)
        {
            List<TConstructor> constructors = new List<TConstructor>();
            List<TMethod> methods = new List<TMethod>();
            List<AbstractMethodWithMonoCecil> abstractMethods = new List<AbstractMethodWithMonoCecil>();
            List<ConversionOperatorWithMonoCecil> conversionOperators = new List<ConversionOperatorWithMonoCecil>();
            List<OperatorOverloadWithMonoCecil> operatorOverloads = new List<OperatorOverloadWithMonoCecil>();
            List<ExplicitInterfaceMethodWithMonoCecil> explicitInterfaceMethods = new List<ExplicitInterfaceMethodWithMonoCecil>();
            List<ExtensionMethodWithMonoCecil> extensionMethods = new List<ExtensionMethodWithMonoCecil>();
            //MethodDefinition destructorMethod = new Action(Finalize).Method;
            foreach (MethodDefinition method in declaringType.TypeDefinition.Methods)
            {
                /*if (method. == destructorMethod)
                {
                    Destructor = method;
                }
                else*/ if (method.IsAbstract)
                {
                    abstractMethods.Add(new AbstractMethodWithMonoCecil(declaringType, method));
                }
                else if (!method.IsSpecialName)
                {
                    //TypeDefinition interfaceType;
                    if (method.IsDefined(declaringType.Assembly, typeof(ExtensionAttribute)))
                    {
                        extensionMethods.Add(new ExtensionMethodWithMonoCecil(declaringType, method));
                    }
                    /*else if (interfaceMethods.TryGetValue(method, out interfaceType))
                    {
                        explicitInterfaceMethods.Add(new ExplicitInterfaceMethodWithMonoCecil(declaringType, interfaceType, method));
                    }*/
                    else
                    {
                        methods.Add(methodFactory(declaringType, method));
                    }
                }
                else if (method.Name == "ctor")
                {
                    constructors.Add(constructorFactory(declaringType, method));
                }
                else if (method.Name == "cctor")
                {
                    StaticConstructorWithMonoCecil = new StaticConstructorWithMonoCecil(declaringType, method);
                }
                else if (method.Name == "op_Implicit")
                {
                    conversionOperators.Add(new ConversionOperatorWithMonoCecil(declaringType, method));
                }
                else if (method.Name == "op_Explicit")
                {
                    conversionOperators.Add(new ConversionOperatorWithMonoCecil(declaringType, method));
                }
                else if (method.Name.StartsWith("op_"))
                {
                    operatorOverloads.Add(new OperatorOverloadWithMonoCecil(declaringType, method));
                }
            }

            ConstructorsWithMonoCecil = constructors;
            AbstractMethodsWithMonoCecil = abstractMethods;
            ConversionOperatorsWithMonoCecil = conversionOperators;
            MethodsWithMonoCecil = methods;
            OperatorOverloadsWithMonoCecil = operatorOverloads;
            ExplicitInterfaceMethodsWithMonoCecil = explicitInterfaceMethods;
            ExtensionMethodsWithMonoCecil = extensionMethods;
        }

        public IReadOnlyCollection<TConstructor> ConstructorsWithMonoCecil { get; private set; }

        public StaticConstructorWithMonoCecil StaticConstructorWithMonoCecil { get; set; }

        public IReadOnlyCollection<ConversionOperatorWithMonoCecil> ConversionOperatorsWithMonoCecil { get; private set; }

        public IReadOnlyCollection<AbstractMethodWithMonoCecil> AbstractMethodsWithMonoCecil { get; private set; }

        public IReadOnlyCollection<TMethod> MethodsWithMonoCecil { get; private set; }

        public IReadOnlyCollection<ExtensionMethodWithMonoCecil> ExtensionMethodsWithMonoCecil { get; private set; }

        public IReadOnlyCollection<OperatorOverloadWithMonoCecil> OperatorOverloadsWithMonoCecil { get; private set; }

        public MethodDefinition Destructor { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceMethodWithMonoCecil> ExplicitInterfaceMethodsWithMonoCecil { get; private set; }
    }
}
