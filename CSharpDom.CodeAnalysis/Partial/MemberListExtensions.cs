using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal static class MemberListExtensions
    {
        internal static void AddPartialMethods<TParentNode, TParentSyntax, TPartialMethods>(
            this MemberList<TParentNode, TParentSyntax> members,
            TPartialMethods methods,
            string insertPartialMethodsAfter = "Methods")
            where TParentSyntax : class
            where TPartialMethods : 
                IReadOnlyCollection<ClassMethodWithCodeAnalysis>,
                IHasPartialMethodDefinitions<PartialMethodDefinitionWithCodeAnalysis>,
                IHasPartialMethodImplementations<PartialMethodImplementationWithCodeAnalysis>
        {
            members.Replace("Methods", () => methods.Select(item => item.Syntax));
            members.InsertAfter(
                insertPartialMethodsAfter,
                nameof(methods.PartialMethodDefinitions),
                () => methods.PartialMethodDefinitions.Select(item => item.Syntax));
            members.InsertAfter(
                insertPartialMethodsAfter,
                nameof(methods.PartialMethodImplementations),
                () => methods.PartialMethodImplementations.Select(item => item.Syntax));
        }
    }
}
