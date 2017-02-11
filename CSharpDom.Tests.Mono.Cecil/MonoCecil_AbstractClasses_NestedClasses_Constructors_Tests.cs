using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_AbstractClasses_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicConstructor));
        }
    }
}
