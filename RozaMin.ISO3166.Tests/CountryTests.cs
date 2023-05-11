namespace RozaMin.ISO3166.Tests
{
    public class CountryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void All_Returns249Countries_WhenCalled()
        {
            // Arrange & Act
            var actualCountries = Country.All;

            Assert.That(actualCountries.Count(), Is.EqualTo(249));
        }

        [Test]
        public void CountryNameProperties_MatchTheNameOfTheReturningCountry_WhenCalled()
        {
            foreach (var prop in typeof(Country)
                                    .GetProperties()
                                    .Where(x => x.GetMethod?.ReturnType == typeof(Country)))
            {
                var country = (Country?)prop.GetValue(default);

                StringAssert.AreEqualIgnoringCase(prop.Name, country?.Name.Replace(" ", ""));
            }
        }

        [Test]
        public void Afghanistan_AllReturnsAreInstanceEqual_WhenCalledTwice()
        {
            // Arrange & Act
            var actualCountry = Country.Afghanistan;
            var expectedCountry = Country.Afghanistan;

            Assert.That(actualCountry, Is.SameAs(expectedCountry));
        }

        [Test]
        public void Afghanistan_AllReturnsAreEqual_WhenCalledTwice()
        {
            // Arrange & Act
            var actualCountry = Country.Afghanistan;
            var expectedCountry = Country.Afghanistan;

            Assert.That(actualCountry, Is.EqualTo(expectedCountry));
        }

        [Test]
        public void NumericCodes_HaveThreeDigits_ForAllCountries()
        {
            foreach (var item in Country.All)
            {
                Assert.Multiple(() =>
                {
                    Assert.DoesNotThrow(() => int.Parse(item.NumericCode.ToString()));
                    Assert.That(item.NumericCode.ToString(), Has.Length.EqualTo(3));
                });
            }
        }

        [Test]
        public void NumericCodes_AreUnique_ForAllCountries()
        {
            var query = from c in Country.All
                        group c by int.Parse(c.NumericCode) into g
                        select new { code = g.Key, occurrence = g.Count() };

            var hasMoreThanOnceItem = query.Count(x => x.occurrence > 1);

            Assert.That(hasMoreThanOnceItem, Is.Zero);
        }

        [Test]
        public void TwoLetterCodes_HaveTwoCharacter_ForAllCountries()
        {
            foreach (var item in Country.All)
            {
                Assert.That(item.TwoLetterCode, Has.Length.EqualTo(2));
            }
        }

        [Test]
        public void TwoLetterCodes_AreUnique_ForAllCountries()
        {
            var query = from c in Country.All
                        group c by c.TwoLetterCode into g
                        select new { code = g.Key, occurrence = g.Count() };

            var hasMoreThanOnceItem = query.Count(x => x.occurrence > 1);

            Assert.That(hasMoreThanOnceItem, Is.Zero);
        }

        [Test]
        public void ThreeLetterCodes_HaveTwoCharacter_ForAllCountries()
        {
            foreach (var item in Country.All)
            {
                Assert.That(item.ThreeLetterCode, Has.Length.EqualTo(3));
            }
        }

        [Test]
        public void ThreeLetterCodes_AreUnique_ForAllCountries()
        {
            var query = from c in Country.All
                        group c by c.ThreeLetterCode into g
                        select new { code = g.Key, occurrence = g.Count() };

            var hasMoreThanOnceItem = query.Count(x => x.occurrence > 1);

            Assert.That(hasMoreThanOnceItem, Is.Zero);
        }
    }
}