using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public class AttributeWithMonoCecil :
        AbstractAttributeGroup<IAttributeWithMonoCecil>,
        IAttributeWithMonoCecil//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly IAttributeWithMonoCecil attribute;

        internal AttributeWithMonoCecil(AssemblyWithMonoCecil assembly, CustomAttribute attribute)
        {
            this.attribute = new InternalAttributeWithMonoCecil(assembly, attribute);
        }

        public override IReadOnlyCollection<IAttributeWithMonoCecil> Attributes
        {
            get { return new IAttributeWithMonoCecil[] { attribute }; }
        }

        public ClassReferenceWithMonoCecil AttributeType
        {
            get { return attribute.AttributeType; }
        }

        public IReadOnlyCollection<NamedAttributeValueWithMonoCecil> NamedValues
        {
            get { return attribute.NamedValues; }
        }

        public IReadOnlyList<UnnamedAttributeValueWithMonoCecil> UnnamedValues
        {
            get { return attribute.UnnamedValues; }
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
