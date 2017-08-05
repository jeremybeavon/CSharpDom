using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
