using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceMethodWithReflection :
        AbstractInterfaceMethod<
            AttributeWithReflection,
            IBasicTypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection>
    {
        private readonly MethodInfo method;
        private readonly IBasicTypeWithReflection declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithReflection returnType;
        private readonly Lazy<Parameters> parameters;

        internal InterfaceMethodWithReflection(IBasicTypeWithReflection declaringType, MethodInfo method)
        {
            this.method = method;
            this.declaringType = declaringType;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(method));
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType);
            parameters = new Lazy<Parameters>(() => new Parameters(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithReflection; }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                if (method.IsHideBySig)
                {
                    return InterfaceMemberInheritanceModifier.New;
                }

                return InterfaceMemberInheritanceModifier.None;
            }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }
    }
}
