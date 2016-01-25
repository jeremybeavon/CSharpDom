using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection
{
    public sealed class GenericParameterDeclarationWithReflection :
        AbstractGenericParameterDeclaration<
            ClassReferenceWithReflection,
            GenericParameterReferenceWithReflection,
            InterfaceReferenceWithReflection,
            AttributeWithReflection>
    {
        internal GenericParameterDeclarationWithReflection(Type type)
        {
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ClassReferenceWithReflection BaseClassConstraint
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<GenericParameterReferenceWithReflection> GenericParameterConstraints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool HasEmptyConstructorConstraint
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> InterfaceConstraints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override GenericParameterTypeConstraint TypeConstraint
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
