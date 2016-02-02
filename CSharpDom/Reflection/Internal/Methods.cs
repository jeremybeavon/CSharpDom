using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class Methods
    {
        public Methods(ITypeWithReflection declaringType, Type type)
        {
            List<MethodWithReflection> methods = new List<MethodWithReflection>();
            List<ConversionOperatorWithReflection> conversionOperators = new List<ConversionOperatorWithReflection>();
            List<OperatorOverloadWithReflection> operatorOverloads = new List<OperatorOverloadWithReflection>();
            MethodInfo destructorMethod = new Action(Finalize).Method;
            foreach (MethodInfo method in type.GetAllMethods())
            {
                if (!method.IsSpecialName)
                {
                    methods.Add(new MethodWithReflection(declaringType, method));
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

        public IReadOnlyCollection<MethodWithReflection> MethodsWithReflection { get; private set; }

        public IReadOnlyCollection<OperatorOverloadWithReflection> OperatorOverloadsWithReflection { get; private set; }

        public MethodInfo Destructor { get; private set; }

        public IReadOnlyCollection<ExplicitInterfaceMethodWithReflection> ExplicitInterfaceMethodsWithReflection { get; private set; }
    }
}
