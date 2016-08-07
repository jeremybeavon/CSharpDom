using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class FieldGroupWithMonoCecil : 
        AbstractFieldGroup<AttributeWithMonoCecil, ITypeWithMonoCecil, ITypeReferenceWithMonoCecil, IFieldWithMonoCecil>,
        IHasFieldDefinition
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly FieldDefinition field;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil fieldType;

        internal FieldGroupWithMonoCecil(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            this.declaringType = declaringType;
            this.field = field;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, field));
            RequiredModifierType modifierType = field.FieldType as RequiredModifierType;
            fieldType = TypeReferenceWithMonoCecilFactory.CreateReference(
                assembly,
                modifierType == null ? field.FieldType : modifierType.ElementType,
                field);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return attributes.Value.AttributesWithMonoCecil; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return declaringType; }
        }

        public FieldDefinition FieldDefinition
        {
            get { return field; }
        }

        public override ITypeReferenceWithMonoCecil FieldType
        {
            get { return fieldType; }
        }

        public ClassFieldModifier Modifier
        {
            get
            {
                ClassFieldModifier modifier = NonNewModifier;
                IInternalTypeWithMonoCecil internalType = declaringType as IInternalTypeWithMonoCecil;
                if (internalType == null || !internalType.HiddenMembersAnalyzer.IsFieldHidden(field))
                {
                    return modifier;
                }

                switch (modifier)
                {
                    case ClassFieldModifier.None:
                        return ClassFieldModifier.New;
                    case ClassFieldModifier.Static:
                        return ClassFieldModifier.NewStatic;
                    case ClassFieldModifier.StaticReadOnly:
                        return ClassFieldModifier.NewStaticReadOnly;
                    case ClassFieldModifier.StaticVolatile:
                        return ClassFieldModifier.NewStaticVolatile;
                    case ClassFieldModifier.Volatile:
                        return ClassFieldModifier.NewVolatile;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public override IReadOnlyCollection<IFieldWithMonoCecil> Fields
        {
            get { return new IFieldWithMonoCecil[0]; }
        }

        public ClassFieldModifier NonNewModifier
        {
            get
            {
                if (field.IsStatic)
                {
                    if (field.IsInitOnly)
                    {
                        return ClassFieldModifier.StaticReadOnly;
                    }

                    if (field.IsVolatile())
                    {
                        return ClassFieldModifier.StaticVolatile;
                    }

                    return ClassFieldModifier.Static;
                }

                if (field.IsInitOnly)
                {
                    return ClassFieldModifier.ReadOnly;
                }

                if (field.IsVolatile())
                {
                    return ClassFieldModifier.Volatile;
                }

                return ClassFieldModifier.None;
            }
        }
    }
}
