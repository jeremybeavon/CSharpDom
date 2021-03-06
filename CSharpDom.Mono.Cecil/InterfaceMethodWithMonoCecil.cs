﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class InterfaceMethodWithMonoCecil :
        AbstractInterfaceMethod<
            AttributeWithMonoCecil,
            IInterfaceTypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            MethodParameterWithMonoCecil>
    {
        private readonly MethodDefinition method;
        private readonly IInterfaceTypeWithMonoCecil declaringType;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Attributes> returnAttributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithMonoCecil returnType;
        private readonly Lazy<Parameters<MethodParameterWithMonoCecil>> parameters;

        internal InterfaceMethodWithMonoCecil(IInterfaceTypeWithMonoCecil declaringType, MethodDefinition method)
        {
            this.method = method;
            this.declaringType = declaringType;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            returnAttributes = new Lazy<Attributes>(() => new Attributes(assembly, method.MethodReturnType));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(assembly, method));
            returnType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, method.ReturnType, method);
            parameters = new Lazy<Parameters<MethodParameterWithMonoCecil>>(
                () => new Parameters<MethodParameterWithMonoCecil>(assembly, method, parameter => new MethodParameterWithMonoCecil(parameter)));
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override IInterfaceTypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithMonoCecil; }
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

        public override IReadOnlyList<MethodParameterWithMonoCecil> Parameters
        {
            get { return parameters.Value.ParametersWithMonoCecil; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return returnType; }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> ReturnAttributes
        {
            get { return returnAttributes.Value.AttributesWithMonoCecil; }
        }
    }
}
