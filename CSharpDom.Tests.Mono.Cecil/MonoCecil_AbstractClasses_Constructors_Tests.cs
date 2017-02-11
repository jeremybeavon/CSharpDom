using CSharpDom.TestTarget.AbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_AbstractClasses_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicConstructor));
        }
    }
}
