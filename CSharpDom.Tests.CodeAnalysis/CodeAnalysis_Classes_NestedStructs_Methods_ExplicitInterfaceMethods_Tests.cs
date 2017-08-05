using CSharpDom.TestTarget.Classes.NestedStructs.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
