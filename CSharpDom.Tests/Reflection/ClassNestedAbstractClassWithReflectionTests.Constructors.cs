using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedAbstractClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithConstructorWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithConstructorWith1Parameter()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithConstructorWith2Parameters()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithInternalConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithConstructorWithParametersWithAttributes()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithConstructorWithParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPrivateConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedInternalConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPublicConstructor()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicConstructor));
        }

    }
}