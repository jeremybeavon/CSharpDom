using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Methods<TMethod>
    {
        public Methods(
            ITypeWithReflection declaringType,
            Type type,
            Func<ITypeWithReflection, MethodInfo, TMethod> methodFactory,
            ISet<MethodInfo> interfaceMethods)
        {
            List<TMethod> methods = new List<TMethod>();
            List<ConversionOperatorWithReflection> conversionOperators = new List<ConversionOperatorWithReflection>();
            List<OperatorOverloadWithReflection> operatorOverloads = new List<OperatorOverloadWithReflection>();
            List<ExplicitInterfaceMethodWithReflection> explicitInterfaceMethods = new List<ExplicitInterfaceMethodWithReflection>();
            MethodInfo destructorMethod = new Action(Finalize).Method;
            foreach (MethodInfo method in type.GetAllMethods())
            {
                if (!method.IsSpecialName)
                {
                    if (interfaceMethods.Contains(method))
                    {
                        explicitInterfaceMethods.Add(new ExplicitInterfaceMethodWithReflection(declaringType, method));
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
                else if (method.GetBaseDefinition() == destructorMethod)
                {
                    Destructor = method;
                }
            }

            ConversionOperatorsWithReflection = conversionOperators;
            MethodsWithReflection = methods;
            OperatorOverloadsWithReflection = operatorOverloads;
        }

        public IReadOnlyCollection<ConversionOperatorWithReflection> ConversionOperatorsWithReflection { get; private set; }

        public IReadOnlyCollection<TMethod> MethodsWithReflection { get; private set; }

        public IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloadsWithReflection { get; private set; }

        public MethodInfo Destructor { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethodsWithReflection { get; private set; }
    }
}
