using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class InternalAttributeWithCodeAnalysis :
        AbstractAttribute<ClassReferenceWithCodeAnalysis, UnnamedAttributeValueWithCodeAnalysis, NamedAttributeValueWithCodeAnalysis>,
        IAttributeWithCodeAnalysis
    {
        private readonly ClassReferenceWithCodeAnalysis attributeType;
        private readonly IReadOnlyCollection<NamedAttributeValueWithCodeAnalysis> namedAttributeValues;
        private readonly IReadOnlyList<UnnamedAttributeValueWithCodeAnalysis> unnamedAttributeValues;

        internal InternalAttributeWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, CustomAttribute attribute)
        {
            attributeType = new ClassReferenceWithCodeAnalysis(assembly, attribute.AttributeType);
            namedAttributeValues = attribute.Fields
                .Concat(attribute.Properties)
                .Select(value => new NamedAttributeValueWithCodeAnalysis(assembly, value))
                .ToList();
            unnamedAttributeValues = attribute.ConstructorArguments
                .Select(value => new UnnamedAttributeValueWithCodeAnalysis(assembly, value))
                .ToList();
        }
        
        public override ClassReferenceWithCodeAnalysis AttributeType
        {
            get { return attributeType; }
        }

        public override IReadOnlyCollection<NamedAttributeValueWithCodeAnalysis> NamedValues
        {
            get { return namedAttributeValues; }
        }

        public override IReadOnlyList<UnnamedAttributeValueWithCodeAnalysis> UnnamedValues
        {
            get { return unnamedAttributeValues; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAttributeWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
