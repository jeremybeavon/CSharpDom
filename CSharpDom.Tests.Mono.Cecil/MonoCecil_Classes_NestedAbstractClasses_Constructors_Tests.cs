using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Classes_NestedAbstractClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicConstructor));
        }
    }
}
