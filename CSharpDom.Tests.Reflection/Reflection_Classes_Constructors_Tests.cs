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
        public void TestClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1ParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithPublicConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithPrivateConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalConstructor));
        }
    }
}
