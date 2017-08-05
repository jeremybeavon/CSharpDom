using CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstructorWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstructorWith1ParameterUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstructorWith2ParametersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicConstructorUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
