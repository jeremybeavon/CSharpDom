using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class FieldGroupWithCodeAnalysis : 
        AbstractFieldGroup<AttributeGroupWithCodeAnalysis, ITypeWithCodeAnalysis, ITypeReferenceWithCodeAnalysis, IFieldWithCodeAnalysis>,
        IHasFieldDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly FieldDefinition field;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithCodeAnalysis fieldType;

        internal FieldGroupWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            this.declaringType = declaringType;
            this.field = field;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, field));
            RequiredModifierType modifierType = field.FieldType as RequiredModifierType;
            fieldType = TypeReferenceWithCodeAnalysisFactory.CreateReference(
                assembly,
                modifierType == null ? field.FieldType : modifierType.ElementType,
                field);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public FieldDefinition FieldDefinition
        {
            get { return field; }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return fieldType; }
        }

        public ClassFieldModifier Modifier
        {
            get
            {
                ClassFieldModifier modifier = NonNewModifier;
                IInternalTypeWithCodeAnalysis internalType = declaringType as IInternalTypeWithCodeAnalysis;
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

        public override IReadOnlyCollection<IFieldWithCodeAnalysis> Fields
        {
            get { return new IFieldWithCodeAnalysis[0]; }
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
