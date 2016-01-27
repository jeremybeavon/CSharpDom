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
        private readonly string name;
        private readonly TypeContainer typeContainer;

        internal NamespaceWithReflection(string name, TypeContainer typeContainer)
        {
            this.name = name;
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<ClassWithReflection> Classes
        {
            get { return typeContainer.Classes; }
        }

        public override IReadOnlyCollection<DelegateWithReflection> Delegates
        {
            get { return typeContainer.Delegates; }
        }

        public override IReadOnlyCollection<EnumWithReflection> Enums
        {
            get { return typeContainer.Enums; }
        }

        public override IReadOnlyCollection<InterfaceWithReflection> Interfaces
        {
            get { return typeContainer.Interfaces; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override IReadOnlyCollection<StructWithReflection> Structs
        {
            get { return typeContainer.Structs; }
        }
    }
}
