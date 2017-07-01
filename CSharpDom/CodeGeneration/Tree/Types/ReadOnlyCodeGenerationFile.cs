using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyCodeGenerationFile :
        AbstractLoadedDocument<
            SolutionNotSupported,
            ProjectNotSupported,
            DocumentNotSupported,
            ReadOnlyUsingDeclaration,
            AttributeGroupNotSupported,
            ReadOnlyNamespace,
            ReadOnlyClassCollection,
            ReadOnlyDelegate,
            ReadOnlyEnum,
            ReadOnlyInterface,
            ReadOnlyStructCollection>
    {
        private readonly IReadOnlyCollection<ReadOnlyUsingDeclaration> usingDeclarations;
        private readonly IReadOnlyCollection<ReadOnlyNamespace> namespaces;
        private readonly ReadOnlyClassCollection classes;
        private readonly IReadOnlyCollection<ReadOnlyDelegate> delegates;
        private readonly IReadOnlyCollection<ReadOnlyEnum> enums;
        private readonly IReadOnlyCollection<ReadOnlyInterface> interfaces;
        private readonly ReadOnlyStructCollection structs;

        public ReadOnlyCodeGenerationFile(CodeGenerationFile codeGenerationFile)
        {
            usingDeclarations = codeGenerationFile.Usings.ToArray(@using => new ReadOnlyUsingDeclaration(@using));
            namespaces = codeGenerationFile.Namespaces.ToArray(@namespace => new ReadOnlyNamespace(@namespace));
            classes = new ReadOnlyClassCollection(codeGenerationFile.Classes);
            delegates = codeGenerationFile.Delegates.ToArray(@delegate => new ReadOnlyDelegate(@delegate));
            enums = codeGenerationFile.Enums.ToArray(@enum => new ReadOnlyEnum(@enum));
            interfaces = codeGenerationFile.Interfaces.ToArray(@interface => new ReadOnlyInterface(@interface));
            structs = new ReadOnlyStructCollection(codeGenerationFile.Structs);
        }

        public override ReadOnlyClassCollection Classes
        {
            get { return classes; }
        }

        public override IReadOnlyCollection<ReadOnlyDelegate> Delegates
        {
            get { return delegates; }
        }

        public override DocumentNotSupported Document
        {
            get { return new DocumentNotSupported(); }
        }

        public override IReadOnlyCollection<ReadOnlyEnum> Enums
        {
            get { return enums; }
        }

        public override IReadOnlyCollection<ReadOnlyInterface> Interfaces
        {
            get { return interfaces; }
        }

        public override IReadOnlyCollection<ReadOnlyNamespace> Namespaces
        {
            get { return namespaces; }
        }

        public override ProjectNotSupported Project
        {
            get { return new ProjectNotSupported(); }
        }

        public override SolutionNotSupported Solution
        {
            get { return new SolutionNotSupported(); }
        }

        public override ReadOnlyStructCollection Structs
        {
            get { return structs; }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> AssemblyAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> ModuleAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IReadOnlyCollection<ReadOnlyUsingDeclaration> UsingDirectives
        {
            get { return usingDeclarations; }
        }
    }
}
