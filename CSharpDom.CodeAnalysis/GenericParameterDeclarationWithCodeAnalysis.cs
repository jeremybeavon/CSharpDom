using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class GenericParameterDeclarationWithCodeAnalysis :
        AbstractGenericParameterDeclaration<
            ClassReferenceWithCodeAnalysis,
            GenericParameterReferenceWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly GenericParameter type;
        private readonly Lazy<Attributes> attributes;
        private readonly GenericParameterTypeConstraint typeConstraint;
        private readonly bool hasEmptyConstructorConstraint;
        private readonly ClassReferenceWithCodeAnalysis baseClassConstraint;
        private readonly List<GenericParameterReferenceWithCodeAnalysis> genericParameterConstraints;
        private readonly List<InterfaceReferenceWithCodeAnalysis> interfaceConstraints;
        private readonly GenericParameterDeclarationDirection direction;

        internal GenericParameterDeclarationWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, GenericParameter type)
        {
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, type));
            typeConstraint = GetTypeConstraint(type);
            direction = GetDirection(type);
            hasEmptyConstructorConstraint = type.HasDefaultConstructorConstraint && !type.HasNotNullableValueTypeConstraint;
            genericParameterConstraints = new List<GenericParameterReferenceWithCodeAnalysis>();
            interfaceConstraints = new List<InterfaceReferenceWithCodeAnalysis>();
            foreach (TypeReference constraintType in type.Constraints)
            {
                TypeDefinition constraintTypeDefinition = constraintType.Resolve();
                if (constraintType.IsGenericParameter)
                {
                    genericParameterConstraints.Add(new GenericParameterReferenceWithCodeAnalysis(constraintType));
                }
                else if (constraintTypeDefinition.IsInterface)
                {
                    interfaceConstraints.Add(new InterfaceReferenceWithCodeAnalysis(assembly, constraintType));
                }
                else if (constraintTypeDefinition.IsClass)
                {
                    if (baseClassConstraint != null)
                    {
                        throw new InvalidOperationException("GenericParameterDeclaration appears to have 2 base classes.");
                    }

                    if (constraintType.FullName != "System.ValueType")
                    {
                        baseClassConstraint = new ClassReferenceWithCodeAnalysis(assembly, constraintType);
                    }
                }
                else
                {
                    throw new InvalidOperationException("Unknown constraint type.");
                }
            }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ClassReferenceWithCodeAnalysis BaseClassConstraint
        {
            get { return baseClassConstraint; }
        }

        public override IReadOnlyCollection<GenericParameterReferenceWithCodeAnalysis> GenericParameterConstraints
        {
            get { return genericParameterConstraints; }
        }

        public override bool HasEmptyConstructorConstraint
        {
            get { return hasEmptyConstructorConstraint; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithCodeAnalysis> InterfaceConstraints
        {
            get { return interfaceConstraints; }
        }

        public override string Name
        {
            get { return type.Name; }
        }
        
        public override GenericParameterTypeConstraint TypeConstraint
        {
            get { return typeConstraint; }
        }

        public override GenericParameterDeclarationDirection Direction
        {
            get { return direction; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitGenericParameterDeclarationWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/

        private static GenericParameterTypeConstraint GetTypeConstraint(GenericParameter type)
        {
            if (type.HasReferenceTypeConstraint)
            {
                return GenericParameterTypeConstraint.Class;
            }

            if (type.HasNotNullableValueTypeConstraint)
            {
                return GenericParameterTypeConstraint.Struct;
            }

            return GenericParameterTypeConstraint.None;
        }

        private static GenericParameterDeclarationDirection GetDirection(GenericParameter type)
        {
            if (type.IsContravariant)
            {
                return GenericParameterDeclarationDirection.In;
            }

            if (type.IsCovariant)
            {
                return GenericParameterDeclarationDirection.Out;
            }

            return GenericParameterDeclarationDirection.None;
        }
    }
}
