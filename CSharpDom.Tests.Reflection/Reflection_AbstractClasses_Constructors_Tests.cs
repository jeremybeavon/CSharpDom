using CSharpDom.TestTarget.AbstractClasses.Constructors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Constructors_Tests : AbstractSolutionWithReflectionTests
    {
        public Reflection_AbstractClasses_Constructors_Tests()
        {
            IsConstructorTest = true;
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith1ParameterUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWith1Parameter));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWith2ParametersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWith2Parameters));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWithParametersWithAttributesUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestAbstractClassWithConstructorWithParametersWithModifiersUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithConstructorWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalConstructor));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicConstructorUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicConstructor));
        }
    }
}
