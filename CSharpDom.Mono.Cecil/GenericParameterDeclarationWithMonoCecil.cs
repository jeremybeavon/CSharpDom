using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil
{
    public sealed class GenericParameterDeclarationWithMonoCecil :
        AbstractGenericParameterDeclaration<
            ClassReferenceWithMonoCecil,
            GenericParameterReferenceWithMonoCecil,
            InterfaceReferenceWithMonoCecil,
            AttributeWithMonoCecil>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly GenericParameter type;
        private readonly Lazy<Attributes> attributes;
        private readonly GenericParameterTypeConstraint typeConstraint;
        private readonly bool hasEmptyConstructorConstraint;
        private readonly ClassReferenceWithMonoCecil baseClassConstraint;
        private readonly List<GenericParameterReferenceWithMonoCecil> genericParameterConstraints;
        private readonly List<InterfaceReferenceWithMonoCecil> interfaceConstraints;
        private readonly GenericParameterDeclarationDirection direction;

        internal GenericParameterDeclarationWithMonoCecil(AssemblyWithMonoCecil assembly, GenericParameter type)
        {
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, type));
            typeConstraint = GetTypeConstraint(type);
            direction = GetDirection(type);
            hasEmptyConstructorConstraint = type.HasDefaultConstructorConstraint && !type.HasNotNullableValueTypeConstraint;
            genericParameterConstraints = new List<GenericParameterReferenceWithMonoCecil>();
            interfaceConstraints = new List<InterfaceReferenceWithMonoCecil>();
            foreach (TypeReference constraintType in type.Constraints)
            {
                TypeDefinition constraintTypeDefinition = constraintType.Resolve();
                if (constraintType.IsGenericParameter)
                {
                    genericParameterConstraints.Add(new GenericParameterReferenceWithMonoCecil(constraintType));
                }
                else if (constraintTypeDefinition.IsInterface)
                {
                    interfaceConstraints.Add(new InterfaceReferenceWithMonoCecil(assembly, constraintType));
                }
                else if (constraintTypeDefinition.IsClass)
                {
                    if (baseClassConstraint != null)
                    {
                        throw new InvalidOperationException("GenericParameterDeclaration appears to have 2 base classes.");
                    }

                    if (constraintType.FullName != "System.ValueType")
                    {
                        baseClassConstraint = new ClassReferenceWithMonoCecil(assembly, constraintType);
                    }
                }
                else
                {
                    throw new InvalidOperationException("Unknown constraint type.");
                }
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ClassReferenceWithMonoCecil BaseClassConstraint
        {
            get { return baseClassConstraint; }
        }

        public override IReadOnlyCollection<GenericParameterReferenceWithMonoCecil> GenericParameterConstraints
        {
            get { return genericParameterConstraints; }
        }

        public override bool HasEmptyConstructorConstraint
        {
            get { return hasEmptyConstructorConstraint; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithMonoCecil> InterfaceConstraints
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
            visitor.VisitGenericParameterDeclarationWithMonoCecil(this);
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
