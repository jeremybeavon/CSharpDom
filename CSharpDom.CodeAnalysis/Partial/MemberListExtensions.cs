using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common.Partial;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal static class MemberListExtensions
    {
        internal static void AddClassPartialMethods<TPartialMethods>(
            this IMemberList members,
            TPartialMethods methods,
            string insertPartialMethodsAfter = "Methods")
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

        internal static void AddSealedClassPartialMethods<TPartialMethods>(
            this IMemberList members,
            TPartialMethods methods,
            string insertPartialMethodsAfter = "Methods")
            where TPartialMethods :
                IReadOnlyCollection<SealedClassMethodWithCodeAnalysis>,
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

        internal static void Replace(this IMemberList members, AbstractPartialClassMethodCollectionWithCodeAnalysis value)
        {
            members.CombineList(
                new MemberListSyntax(nameof(value.AbstractMethods), value.AbstractMethods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.Methods), value.Methods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.ExplicitInterfaceMethods), value.ExplicitInterfaceMethods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.PartialMethodDefinitions), value.PartialMethodDefinitions.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.PartialMethodImplementations), value.PartialMethodImplementations.Select(method => method.Syntax)));
        }

        internal static void Replace(this IMemberList members, PartialClassMethodCollectionWithCodeAnalysis value)
        {
            members.CombineList(
                new MemberListSyntax(nameof(value.Methods), value.Methods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.ExplicitInterfaceMethods), value.ExplicitInterfaceMethods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.PartialMethodDefinitions), value.PartialMethodDefinitions.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.PartialMethodImplementations), value.PartialMethodImplementations.Select(method => method.Syntax)));
        }

        internal static void Replace(this IMemberList members, SealedPartialClassMethodCollectionWithCodeAnalysis value)
        {
            members.CombineList(
                new MemberListSyntax(nameof(value.Methods), value.Methods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.ExplicitInterfaceMethods), value.ExplicitInterfaceMethods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.PartialMethodDefinitions), value.PartialMethodDefinitions.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(value.PartialMethodImplementations), value.PartialMethodImplementations.Select(method => method.Syntax)));
        }
    }
}
