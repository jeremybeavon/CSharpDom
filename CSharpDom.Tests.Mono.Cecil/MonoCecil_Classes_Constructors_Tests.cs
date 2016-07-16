using CSharpDom.TestTarget.Classes.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithPublicConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestClassWithProtectedConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithPrivateConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithInternalConstructorUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalConstructor));
        }
    }
}
