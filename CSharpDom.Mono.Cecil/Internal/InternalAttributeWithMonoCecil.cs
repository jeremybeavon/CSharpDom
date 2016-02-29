using CSharpDom.BaseClasses;
using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InternalAttributeWithMonoCecil :
        AbstractAttribute<ClassReferenceWithMonoCecil, UnnamedAttributeValueWithMonoCecil, NamedAttributeValueWithMonoCecil>,
        IAttributeWithMonoCecil
    {
        private readonly ClassReferenceWithMonoCecil attributeType;
        private readonly IReadOnlyCollection<NamedAttributeValueWithMonoCecil> namedAttributeValues;
        private readonly IReadOnlyList<UnnamedAttributeValueWithMonoCecil> unnamedAttributeValues;

        internal InternalAttributeWithMonoCecil(AssemblyWithMonoCecil assembly, CustomAttribute attribute)
        {
            attributeType = new ClassReferenceWithMonoCecil(assembly, attribute.AttributeType);
            namedAttributeValues = attribute.Fields
                .Concat(attribute.Properties)
                .Select(value => new NamedAttributeValueWithMonoCecil(assembly, value))
                .ToList();
            unnamedAttributeValues = attribute.ConstructorArguments
                .Select(value => new UnnamedAttributeValueWithMonoCecil(assembly, value))
                .ToList();
        }
        
        public override ClassReferenceWithMonoCecil AttributeType
        {
            get { return attributeType; }
        }

        public override IReadOnlyCollection<NamedAttributeValueWithMonoCecil> NamedValues
        {
            get { return namedAttributeValues; }
        }

        public override IReadOnlyList<UnnamedAttributeValueWithMonoCecil> UnnamedValues
        {
            get { return unnamedAttributeValues; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAttributeWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
