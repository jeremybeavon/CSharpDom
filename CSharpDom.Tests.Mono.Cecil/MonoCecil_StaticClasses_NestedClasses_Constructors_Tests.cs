using CSharpDom.TestTarget.StaticClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithMonoCecilTests
    {
        public MonoCecil_StaticClasses_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith1ParameterUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2ParametersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWithParametersWithAttributesUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWithParametersWithModifiersUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicConstructorUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicConstructor));
        }
    }
}
