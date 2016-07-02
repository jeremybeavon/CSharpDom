using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicConstructorUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
