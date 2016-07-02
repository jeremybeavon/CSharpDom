using CSharpDom.TestTarget.Classes.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicConstructor));
        }
    }
}
