using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class EnumWithReflection :
        AbstractEnum<
            NamespaceWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            AttributeWithReflection,
            EnumMemberWithReflection>
    {
        private readonly AssemblyWithReflection assembly;
        private readonly NamespaceWithReflection @namespace;
        private readonly Type type;

        internal EnumWithReflection(AssemblyWithReflection assembly, NamespaceWithReflection @namespace, Type type)
        {
            this.assembly = assembly;
            this.@namespace = @namespace;
            this.type = type;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<EnumMemberWithReflection> EnumMembers
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

        public override AssemblyWithReflection Solution
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
