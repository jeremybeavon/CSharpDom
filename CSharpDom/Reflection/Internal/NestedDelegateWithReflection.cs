﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedDelegateWithReflection :
        AbstractNestedDelegate<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithReflection declaringType;
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithReflection returnType;
        private readonly Lazy<Parameters> parameters;

        internal NestedDelegateWithReflection(ITypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(type));
            MethodInfo method = type.GetMethod("Invoke");
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType);
            parameters = new Lazy<Parameters>(() => new Parameters(method));
        }
        
        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithReflection; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedDelegateWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}