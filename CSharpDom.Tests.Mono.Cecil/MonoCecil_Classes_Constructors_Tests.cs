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
            TestClassAsync(typeof(ClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestClassWithPublicConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestClassWithPrivateConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestClassWithInternalConstructorUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalConstructor));
        }
    }
}
