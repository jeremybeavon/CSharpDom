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
            fieldType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, field.FieldType);
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
        
        public override IReadOnlyCollection<IFieldWithMonoCecil> Fields
        {
            get { return new IFieldWithMonoCecil[0]; }
        }

        /*public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                if (field.IsPublic)
                {
                    return ClassMemberVisibilityModifier.Public;
                }

                if (field.IsAssembly)
                {
                    return ClassMemberVisibilityModifier.Internal;
                }

                if (field.IsFamilyOrAssembly)
                {
                    return ClassMemberVisibilityModifier.ProtectedInternal;
                }

                if (field.IsFamily)
                {
                    return ClassMemberVisibilityModifier.Protected;
                }

                if (field.IsPrivate)
                {
                    return ClassMemberVisibilityModifier.Private;
                }

                return ClassMemberVisibilityModifier.None;
            }
        }*/
    }
}
