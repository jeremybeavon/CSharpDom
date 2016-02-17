using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class GenericParameterDeclarationWithReflection :
        AbstractGenericParameterDeclaration<
            ClassReferenceWithReflection,
            GenericParameterReferenceWithReflection,
            InterfaceReferenceWithReflection,
            AttributeWithReflection>,
        IHasType//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Type type;
        private readonly Lazy<Attributes> attributes;
        private readonly GenericParameterTypeConstraint typeConstraint;
        private readonly bool hasEmptyConstructorConstraint;
        private readonly ClassReferenceWithReflection baseClassConstraint;
        private readonly List<GenericParameterReferenceWithReflection> genericParameterConstraints;
        private readonly List<InterfaceReferenceWithReflection> interfaceConstraints;
        private readonly GenericParameterDeclarationDirection direction;

        internal GenericParameterDeclarationWithReflection(Type type)
        {
            this.type = type;
            attributes = new Lazy<Attributes>(() => new Attributes(type));
            typeConstraint = GetTypeConstraint(type);
            direction = GetDirection(type);
            hasEmptyConstructorConstraint = 
                type.GenericParameterAttributes.HasFlag(GenericParameterAttributes.DefaultConstructorConstraint) &&
                typeConstraint != GenericParameterTypeConstraint.Struct;
            genericParameterConstraints = new List<GenericParameterReferenceWithReflection>();
            interfaceConstraints = new List<InterfaceReferenceWithReflection>();
            foreach (Type constraintType in type.GetGenericParameterConstraints().Where(constraint => constraint != typeof(ValueType)))
            {
                if (constraintType.IsGenericParameter)
                {
                    genericParameterConstraints.Add(new GenericParameterReferenceWithReflection(constraintType));
                }
                else if (constraintType.IsInterface)
                {
                    interfaceConstraints.Add(new InterfaceReferenceWithReflection(constraintType));
                }
                else if (constraintType.IsClass)
                {
                    if (baseClassConstraint != null)
                    {
                        throw new InvalidOperationException("GenericParameterDeclaration appears to have 2 base classes.");
                    }

                    baseClassConstraint = new ClassReferenceWithReflection(constraintType);
                }
                else
                {
                    throw new InvalidOperationException("Unknown constraint type.");
                }
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ClassReferenceWithReflection BaseClassConstraint
        {
            get { return baseClassConstraint; }
        }

        public override IReadOnlyCollection<GenericParameterReferenceWithReflection> GenericParameterConstraints
        {
            get { return genericParameterConstraints; }
        }

        public override bool HasEmptyConstructorConstraint
        {
            get { return hasEmptyConstructorConstraint; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> InterfaceConstraints
        {
            get { return interfaceConstraints; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public Type Type
        {
            get { return type; }
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
            visitor.VisitGenericParameterDeclarationWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/

        private static GenericParameterTypeConstraint GetTypeConstraint(Type type)
        {
            if (type.GenericParameterAttributes.HasFlag(GenericParameterAttributes.ReferenceTypeConstraint))
            {
                return GenericParameterTypeConstraint.Class;
            }

            if (type.GenericParameterAttributes.HasFlag(GenericParameterAttributes.NotNullableValueTypeConstraint))
            {
                return GenericParameterTypeConstraint.Struct;
            }

            return GenericParameterTypeConstraint.None;
        }

        private static GenericParameterDeclarationDirection GetDirection(Type type)
        {
            if (type.GenericParameterAttributes.HasFlag(GenericParameterAttributes.Contravariant))
            {
                return GenericParameterDeclarationDirection.In;
            }

            if (type.GenericParameterAttributes.HasFlag(GenericParameterAttributes.Covariant))
            {
                return GenericParameterDeclarationDirection.Out;
            }

            return GenericParameterDeclarationDirection.None;
        }
    }
}
