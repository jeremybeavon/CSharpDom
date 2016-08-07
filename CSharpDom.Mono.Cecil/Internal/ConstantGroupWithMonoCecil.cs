using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class ConstantGroupWithMonoCecil : 
        AbstractConstantGroup<AttributeWithMonoCecil, ITypeWithMonoCecil, ITypeReferenceWithMonoCecil, IConstantWithMonoCecil>,
        IConstantWithMonoCecil,
        IHasFieldDefinition
    {
        private readonly ITypeWithMonoCecil declaringType;
        private readonly FieldDefinition field;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithMonoCecil fieldType;

        internal ConstantGroupWithMonoCecil(ITypeWithMonoCecil declaringType, FieldDefinition field)
        {
            this.declaringType = declaringType;
            this.field = field;
            AssemblyWithMonoCecil assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, field));
            fieldType = TypeReferenceWithMonoCecilFactory.CreateReference(assembly, field.FieldType, field);
            ConstantValue = ConstantExpressionFactory.CreateExpression(assembly, field.Constant);
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
        
        public override IReadOnlyCollection<IConstantWithMonoCecil> Constants
        {
            get { return new IConstantWithMonoCecil[0]; }
        }

        public string Name
        {
            get { return field.Name; }
        }

        public IConstantExpressionWithMonoCecil ConstantValue { get; private set; }
    }
}
