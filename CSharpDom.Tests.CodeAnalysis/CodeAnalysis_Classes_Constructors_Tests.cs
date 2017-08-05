using CSharpDom.TestTarget.Classes.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalConstructor));
        }
    }
}
