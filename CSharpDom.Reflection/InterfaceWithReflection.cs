using CSharpDom.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceWithReflection :
        AbstractInterface<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            EventWithReflection,
            PropertyWithReflection,
            IndexerWithReflection,
            MethodWithReflection>,
        IBasicTypeWithReflection
    {
        internal InterfaceWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {

        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<EventWithReflection> Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<IndexerWithReflection> Indexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<MethodWithReflection> Methods
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

        public override NamespaceWithReflection Namespace
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override AssemblyWithReflection Project
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<PropertyWithReflection> Properties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override AssemblyWithReflection Solution
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override TypeVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
