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
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicConstructorUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
