using CSharpDom.TestTarget.Classes.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithConstructorWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithConstructorWith1Parameter()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithConstructorWith2Parameters()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithInternalConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithConstructorWithParametersWithAttributes()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithConstructorWithParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPrivateConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedInternalConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPublicConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicConstructor));
        }

    }
}