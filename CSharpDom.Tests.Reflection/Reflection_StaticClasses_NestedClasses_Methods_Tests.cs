using CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualMethodUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualMethod));
        }
    }
}
