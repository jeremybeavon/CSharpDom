using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class NamespaceWithReflection :
        AbstractNamespace<
            ClassWithReflection,
            DelegateWithReflection,
            EnumWithReflection,
            InterfaceWithReflection,
            StructWithReflection>
    {
        internal NamespaceWithReflection(string name, TypeContainer typeContainer)
        {

        }

        public override IReadOnlyCollection<ClassWithReflection> Classes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<DelegateWithReflection> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<EnumWithReflection> Enums
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<InterfaceWithReflection> Interfaces
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

        public override IReadOnlyCollection<StructWithReflection> Structs
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
