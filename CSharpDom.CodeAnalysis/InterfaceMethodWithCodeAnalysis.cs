using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceMethodWithCodeAnalysis :
        AbstractInterfaceMethod<
            AttributeGroupWithCodeAnalysis,
            IBasicTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis>
    {
        private readonly MethodDefinition method;
        private readonly IBasicTypeWithCodeAnalysis declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Attributes> returnAttributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithCodeAnalysis returnType;
        private readonly Lazy<Parameters<MethodParameterWithCodeAnalysis>> parameters;

        internal InterfaceMethodWithCodeAnalysis(IBasicTypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            this.method = method;
            this.declaringType = declaringType;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            returnAttributes = new Lazy<Attributes>(() => new Attributes(assembly, method.MethodReturnType));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(assembly, method));
            returnType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, method.ReturnType, method);
            parameters = new Lazy<Parameters<MethodParameterWithCodeAnalysis>>(
                () => new Parameters<MethodParameterWithCodeAnalysis>(assembly, method, parameter => new MethodParameterWithCodeAnalysis(parameter)));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override IBasicTypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithCodeAnalysis; }
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

        public override IReadOnlyList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return parameters.Value.ParametersWithCodeAnalysis; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return returnAttributes.Value.AttributesWithCodeAnalysis; }
        }
    }
}
