using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_StaticClasses_NestedSealedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicConstructor));
        }
    }
}
