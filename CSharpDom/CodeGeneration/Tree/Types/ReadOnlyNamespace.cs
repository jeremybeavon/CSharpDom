using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyNamespace :
        AbstractNamespace<
            ReadOnlyUsingDeclaration,
            ReadOnlyNamespace,
            ReadOnlyClassCollection,
            ReadOnlyDelegate,
            ReadOnlyEnum,
            ReadOnlyInterface,
            ReadOnlyStructCollection>
    {
        private readonly string name;
        private readonly IReadOnlyCollection<ReadOnlyUsingDeclaration> usingDirectives;
        private readonly IReadOnlyCollection<ReadOnlyNamespace> namespaces;
        private readonly ReadOnlyClassCollection classes;
        private readonly IReadOnlyCollection<ReadOnlyDelegate> delegates;
        private readonly IReadOnlyCollection<ReadOnlyEnum> enums;
        private readonly IReadOnlyCollection<ReadOnlyInterface> interfaces;
        private readonly ReadOnlyStructCollection structs;

        public ReadOnlyNamespace(Namespace @namespace)
        {
            name = @namespace.Name;
            usingDirectives = @namespace.Usings.ToArray(@using => new ReadOnlyUsingDeclaration(@using));
            namespaces = @namespace.Namespaces.ToArray(inner => new ReadOnlyNamespace(inner));
            classes = new ReadOnlyClassCollection(@namespace.Classes);
            delegates = @namespace.Delegates.ToArray(@delegate => new ReadOnlyDelegate(@delegate));
            enums = @namespace.Enums.ToArray(@enum => new ReadOnlyEnum(@enum));
            interfaces = @namespace.Interfaces.ToArray(@interface => new ReadOnlyInterface(@interface));
            structs = new ReadOnlyStructCollection(@namespace.Structs);
        }

        public override ReadOnlyClassCollection Classes
        {
            get { return classes; }
        }

        public override IReadOnlyCollection<ReadOnlyDelegate> Delegates
        {
            get { return delegates; }
        }

        public override IReadOnlyCollection<ReadOnlyEnum> Enums
        {
            get { return enums; }
        }

        public override IReadOnlyCollection<ReadOnlyInterface> Interfaces
        {
            get { return interfaces; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override ReadOnlyStructCollection Structs
        {
            get { return structs; }
        }

        public override IReadOnlyCollection<ReadOnlyNamespace> Namespaces
        {
            get { return namespaces; }
        }

        public override IReadOnlyCollection<ReadOnlyUsingDeclaration> UsingDirectives
        {
            get { return usingDirectives; }
        }
    }
}
