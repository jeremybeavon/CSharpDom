using System;
using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class LoadedProjectWithCodeAnalysis :
        EditableLoadedProject<
            SolutionWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            NamespaceWithCodeAnalysis,
            ClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceCollectionWithCodeAnalysis,
            StructCollectionWithCodeAnalysis>
    {
        public override ClassCollectionWithCodeAnalysis Classes
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<DelegateWithCodeAnalysis> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<EnumWithCodeAnalysis> Enums
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override InterfaceCollectionWithCodeAnalysis Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<NamespaceWithCodeAnalysis> Namespaces
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override StructCollectionWithCodeAnalysis Structs
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
