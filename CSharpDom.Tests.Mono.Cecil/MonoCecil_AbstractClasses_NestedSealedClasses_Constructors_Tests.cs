using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_AbstractClasses_NestedSealedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }
        
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalConstructorUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicConstructorUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
