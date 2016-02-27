using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class InternalAttributeWithMonoCecil :
        AbstractAttribute<ClassReferenceWithMonoCecil, UnnamedAttributeValueWithMonoCecil, NamedAttributeValueWithMonoCecil>,
        IAttributeWithMonoCecil
    {
        private readonly ClassReferenceWithMonoCecil attributeType;
        private readonly IReadOnlyCollection<NamedAttributeValueWithMonoCecil> namedAttributeValues;
        private readonly IReadOnlyList<UnnamedAttributeValueWithMonoCecil> unnamedAttributeValues;

        internal InternalAttributeWithMonoCecil(CustomAttributeData attribute)
        {
            attributeType = new ClassReferenceWithMonoCecil(attribute.AttributeType);
            namedAttributeValues = attribute.NamedArguments.Select(value => new NamedAttributeValueWithMonoCecil(value)).ToList();
            unnamedAttributeValues = attribute.ConstructorArguments.Select(value => new UnnamedAttributeValueWithMonoCecil(value)).ToList();
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
