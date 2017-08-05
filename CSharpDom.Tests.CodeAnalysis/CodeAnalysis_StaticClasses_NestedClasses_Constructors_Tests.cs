using CSharpDom.TestTarget.StaticClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicConstructor));
        }
    }
}
