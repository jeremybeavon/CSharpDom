using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_Classes_NestedAbstractClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicConstructorUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
