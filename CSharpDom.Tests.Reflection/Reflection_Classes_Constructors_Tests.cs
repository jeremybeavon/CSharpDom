using CSharpDom.TestTarget.Classes.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public async Task TestClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith2ParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithConstructorWith1ParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithPublicConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public async Task TestClassWithProtectedConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithPrivateConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithInternalConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalConstructor));
        }
    }
}
