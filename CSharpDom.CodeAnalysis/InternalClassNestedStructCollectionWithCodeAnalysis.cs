using System.Collections.Generic;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalClassNestedStructCollectionWithCodeAnalysis<TClass> :
        ClassNestedStructCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassMemberListWrapper<TClass, ClassNestedStructWithCodeAnalysis, StructDeclarationSyntax> structs;
        private readonly ClassMemberListWrapper<
            TClass,
            ClassNestedPartialStructWithCodeAnalysis,
            StructDeclarationSyntax> partialStructs;

        internal InternalClassNestedStructCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            structs = new ClassMemberListWrapper<TClass, ClassNestedStructWithCodeAnalysis, StructDeclarationSyntax>(
                classType.InternalNode,
                () => new ClassNestedStructWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            partialStructs = new ClassMemberListWrapper<TClass, ClassNestedPartialStructWithCodeAnalysis, StructDeclarationSyntax>(
                classType.InternalNode,
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
