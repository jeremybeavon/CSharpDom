﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class Delegate :
        IDelegate<
            NamespaceNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroup,
            GenericParameterDeclaration,
            TypeReference,
            Parameter>
    {
        public Delegate()
        {
            Attributes = new List<AttributeGroup>();
            GenericParameters = new List<GenericParameterDeclaration>();
            Parameters = new List<Parameter>();
        }

        public List<AttributeGroup> Attributes { get; set; }

        public List<GenericParameterDeclaration> GenericParameters { get; set; }

        public string Name { get; set; }

        public NamespaceNotSupported Namespace
        {
            get { return null; }
        }

        public List<Parameter> Parameters { get; set; }

        public ProjectNotSupported Project
        {
            get { return null; }
        }

        public TypeReference ReturnType { get; set; }

        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public TypeVisibilityModifier Visibility { get; set; }

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
            visitor.VisitDelegate(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateChildren(this, visitor);
        }
    }
}
