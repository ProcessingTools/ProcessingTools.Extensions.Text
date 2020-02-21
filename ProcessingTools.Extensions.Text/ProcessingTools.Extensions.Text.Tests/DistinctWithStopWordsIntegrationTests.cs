// <copyright file="DistinctWithStopWordsIntegrationTests.cs" company="ProcessingTools">
// Copyright (c) 2020 ProcessingTools. All rights reserved.
// </copyright>

namespace ProcessingTools.Extensions.Text.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    /// <summary>
    /// Distinct with stop words integration tests.
    /// </summary>
    [TestFixture(TestOf = typeof(StringExtensions), Category = "Integration")]
    public class DistinctWithStopWordsIntegrationTests
    {
        /// <summary>
        /// DistinctWithStopWords with valid parameters should return valid IEnumerable.
        /// </summary>
        [Test(TestOf = typeof(StringExtensions), Description = "DistinctWithStopWords with valid parameters should return valid IEnumerable")]
        public void DistinctWithStopWords_WithValidParameters_ShouldReturnValidIEnumerable()
        {
            // Arrange
            var stopWords = new List<string>
            {
                "item",
            };

            var words = new List<string>();

            // Act
            var result = words.DistinctWithStopWords(stopWords);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotSame(words, result);
        }

        /// <summary>
        /// DistinctWithStopWords with empty stopWords should return input words.
        /// </summary>
        [Test(TestOf = typeof(StringExtensions), Description = "DistinctWithStopWords with empty stopWords should return input words")]
        public void DistinctWithStopWords_WithEmptyStopWords_ShouldReturnInputWords()
        {
            // Arrange
            var stopWords = new List<string>();

            var words = new List<string>
            {
                "item1",
            };

            // Act
            var result = words.DistinctWithStopWords(stopWords);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreSame(words, result);
        }
    }
}
