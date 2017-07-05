using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedStructCollectionWithCodeAnalysis :
        EditableClassNestedStructCollection<ClassNestedStructWithCodeAnalysis, ClassNestedPartialStructWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassMemberListWrapper<ClassNestedStructWithCodeAnalysis, StructDeclarationSyntax> structs;
        private readonly ClassMemberListWrapper<
            ClassNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal ClassNestedStructCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            structs = new ClassMemberListWrapper<ClassNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedStructWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            partialStructs = new ClassMemberListWrapper<ClassNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                classType.Node,
                () => new ClassNestedPartialStructWithCodeAnalysis(),
                StructDeclarationSyntaxExtensions.IsPartial);
        }

        public override ICollection<ClassNestedPartialStructWithCodeAnalysis> PartialStructs
        {
            get { return partialStructs; }
            set { classType.Members.CombineList(nameof(PartialStructs), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structs; }
            set { classType.Members.CombineList(nameof(Structs), value.Select(item => item.Syntax)); }
        }
    }
}
