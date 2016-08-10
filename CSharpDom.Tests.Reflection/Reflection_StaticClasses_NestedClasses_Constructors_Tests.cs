using CSharpDom.TestTarget.StaticClasses.NestedClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_StaticClasses_NestedClasses_Constructors_Tests()
        {
            IsNestedConstructorTest = true;
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith1ParameterUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWith2ParametersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicConstructorUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicConstructor));
        }
    }
}
