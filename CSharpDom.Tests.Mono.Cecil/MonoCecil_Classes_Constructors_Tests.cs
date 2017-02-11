using CSharpDom.TestTarget.Classes.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_Classes_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestClass(typeof(ClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestClass(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestClass(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithPublicConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithPrivateConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithInternalConstructorUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalConstructor));
        }
    }
}
