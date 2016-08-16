using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class ConstantGroupWithCodeAnalysis : 
        AbstractConstantGroup<AttributeGroupWithCodeAnalysis, ITypeWithCodeAnalysis, ITypeReferenceWithCodeAnalysis, IConstantWithCodeAnalysis>,
        IConstantWithCodeAnalysis,
        IHasFieldDefinition
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly FieldDefinition field;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithCodeAnalysis fieldType;

        internal ConstantGroupWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            this.declaringType = declaringType;
            this.field = field;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, field));
            fieldType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, field.FieldType, field);
            ConstantValue = ConstantExpressionFactory.CreateExpression(assembly, field.Constant);
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
        
        public override IReadOnlyCollection<IConstantWithCodeAnalysis> Constants
        {
            get { return new IConstantWithCodeAnalysis[0]; }
        }

        public string Name
        {
            get { return field.Name; }
        }

        public IConstantExpressionWithCodeAnalysis ConstantValue { get; private set; }
    }
}
