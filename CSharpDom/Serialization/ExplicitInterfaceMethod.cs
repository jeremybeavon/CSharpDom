﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class ExplicitInterfaceMethod :
        IExplicitInterfaceMethod<AttributeGroup, IType, InterfaceReference, GenericParameterDeclaration, TypeReference, Parameter, MethodBody>
    {
        public ExplicitInterfaceMethod()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<Parameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public MethodBody Body { get; set; }

        public IType DeclaringType
        {
            get { return null; }
        }

        public InterfaceReference ExplicitInterface { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public ClassMemberInheritanceModifier InheritanceModifier { get; set; }

        public bool IsAsync { get; set; }

        public bool IsPartial { get; set; }

        public string Name { get; set; }

        public List<Parameter> Parameters { get; set; }

        public TypeReference ReturnType { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }
        
        IReadOnlyList<GenericParameterDeclaration> IHasGenericParameters<GenericParameterDeclaration>.GenericParameters
        {
            get { return GenericParameters; }
        }

        IReadOnlyList<Parameter> IHasParameters<Parameter>.Parameters
        {
            get { return Parameters; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExplicitInterfaceMethod(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodChildren(this, visitor);
        }
    }
}