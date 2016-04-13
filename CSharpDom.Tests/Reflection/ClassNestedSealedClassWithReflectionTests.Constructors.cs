using CSharpDom.TestTarget.Classes.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithConstructorWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithConstructorWith1Parameter()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithConstructorWith2Parameters()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithInternalConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithConstructorWithParametersWithAttributes()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithConstructorWithParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPrivateConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedInternalConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPublicConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicConstructor));
        }

    }
}