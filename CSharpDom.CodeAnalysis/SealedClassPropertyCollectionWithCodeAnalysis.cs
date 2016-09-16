using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassPropertyCollectionWithCodeAnalysis :
        EditableSealedClassPropertyCollection<
            SealedClassPropertyWithCodeAnalysis,
            ExplicitInterfacePropertyWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassPropertyListWrapper<SealedClassPropertyWithCodeAnalysis> properties;

        internal SealedClassPropertyCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            properties = new ClassPropertyListWrapper<SealedClassPropertyWithCodeAnalysis>(
                classType.Node,
                () => new SealedClassPropertyWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
        }
        
        public override ICollection<ExplicitInterfacePropertyWithCodeAnalysis> ExplicitInterfaceProperties
        {
            get { return classType.Properties.ExplicitInterfaceProperties; }
            set { classType.Properties.ExplicitInterfaceProperties = value; }
        }

        public override ICollection<SealedClassPropertyWithCodeAnalysis> Properties
        {
            get { return properties; }
            set { classType.Members.CombineList(nameof(Properties), value.Select(item => item.Syntax)); }
        }
    }
}
