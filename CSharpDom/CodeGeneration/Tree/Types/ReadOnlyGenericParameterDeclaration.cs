using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyGenericParameterDeclaration :
        AbstractGenericParameterDeclaration<
            ReadOnlyClassReference,
            ReadOnlyGenericParameterReference,
            ReadOnlyInterfaceReference,
            AttributeGroupNotSupported>
    {
        private readonly ReadOnlyClassReference baseClassConstraint;
        private readonly IReadOnlyCollection<ReadOnlyGenericParameterReference> genericParameterConstraints;
        private readonly IReadOnlyCollection<ReadOnlyInterfaceReference> interfaceConstraints;

        private readonly GenericParameter genericParameter;

        public ReadOnlyGenericParameterDeclaration(GenericParameter genericParameter)
        {
            this.genericParameter = genericParameter;
            if (genericParameter.BaseClassConstraint != null)
            {
                baseClassConstraint = new ReadOnlyClassReference(genericParameter.BaseClassConstraint);
            }

            genericParameterConstraints = genericParameter.GenericParameterConstraints
                .ToArray(reference => new ReadOnlyGenericParameterReference(reference));
            interfaceConstraints = genericParameter.InterfaceConstraints
                .ToArray(reference => new ReadOnlyInterfaceReference(reference));
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyClassReference BaseClassConstraint
        {
            get { return baseClassConstraint; }
        }

        public override IReadOnlyCollection<ReadOnlyGenericParameterReference> GenericParameterConstraints
        {
            get { return genericParameterConstraints; }
        }

        public override bool HasEmptyConstructorConstraint
        {
            get { return genericParameter.HasEmptyConstructorConstraint; }
        }

        public override IReadOnlyCollection<ReadOnlyInterfaceReference> InterfaceConstraints
        {
            get { return interfaceConstraints; }
        }

        public override string Name
        {
            get { return genericParameter.Name; }
        }

        public override GenericParameterTypeConstraint TypeConstraint
        {
            get { return genericParameter.TypeConstraint; }
        }

        public static IReadOnlyList<ReadOnlyGenericParameterDeclaration> Create(IEnumerable<GenericParameter> genericParameters)
        {
            return genericParameters.ToArray(parameter => new ReadOnlyGenericParameterDeclaration(parameter));
        }
    }
}
