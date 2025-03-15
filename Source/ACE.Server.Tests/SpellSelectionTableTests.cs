using System;
using System.Linq;
using System.Reflection;
using ACE.Entity.Enum;
using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Tables;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACE.Server.Tests.Factories.Tables
{
    [TestClass]
    public class SpellSelectionTableTests
    {
        [TestMethod]
        public void VerifyChanceTablesSumToOne()
        {
            // Get all private static fields of type ChanceTable<SpellId> from SpellSelectionTable
            var fields = typeof(SpellSelectionTable)
                .GetFields(BindingFlags.NonPublic | BindingFlags.Static)
                .Where(f => f.FieldType == typeof(ChanceTable<SpellId>));

            foreach (var field in fields)
            {
                var chanceTable = (ChanceTable<SpellId>)field.GetValue(null);
                var totalChance = chanceTable.Sum(entry => entry.chance);

                Assert.AreEqual(1.0f, totalChance, 0.0001f, $"ChanceTable {field.Name} does not sum to 1.0");
            }
        }
    }
}
