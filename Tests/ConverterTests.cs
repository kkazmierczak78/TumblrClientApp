using NUnit.Framework;
using System.Globalization;
using TumblrClientApp.Converters;
using TumblrClientApp.Enums;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EnumToIntTest()
        {
            //Text, Quote, Link, Answer, Video, Audio, Photo, Chat
            var intToEnumConverter = new IntEnumConverter();
            Assert.That(intToEnumConverter.Convert(TumblrPostType.Text, typeof(int), null, new CultureInfo("en-us", false)).Equals(0));
            Assert.That(intToEnumConverter.Convert(TumblrPostType.Quote, typeof(int), null, new CultureInfo("en-us", false)).Equals(1));
            Assert.That(intToEnumConverter.Convert(TumblrPostType.Link, typeof(int), null, new CultureInfo("en-us", false)).Equals(2));
            Assert.That(intToEnumConverter.Convert(TumblrPostType.Answer, typeof(int), null, new CultureInfo("en-us", false)).Equals(3));
            Assert.That(intToEnumConverter.Convert(TumblrPostType.Video, typeof(int), null, new CultureInfo("en-us", false)).Equals(4));
            Assert.That(intToEnumConverter.Convert(TumblrPostType.Audio, typeof(int), null, new CultureInfo("en-us", false)).Equals(5));
            Assert.That(intToEnumConverter.Convert(TumblrPostType.Photo, typeof(int), null, new CultureInfo("en-us", false)).Equals(6));
            Assert.That(intToEnumConverter.Convert(TumblrPostType.Chat, typeof(int), null, new CultureInfo("en-us", false)).Equals(7));
        }

        [Test]
        public void IntToEnumTest()
        {
            //Text, Quote, Link, Answer, Video, Audio, Photo, Chat
            var intToEnumConverter = new IntEnumConverter();
            Assert.That(intToEnumConverter.ConvertBack(0, typeof(TumblrPostType), null, new CultureInfo("en-us", false)).Equals(TumblrPostType.Text));
            //Assert.That(intToEnumConverter.Convert(TumblrPostType.Quote, typeof(int), null, new CultureInfo("en-us", false)).Equals(1));
            //Assert.That(intToEnumConverter.Convert(TumblrPostType.Link, typeof(int), null, new CultureInfo("en-us", false)).Equals(2));
            //Assert.That(intToEnumConverter.Convert(TumblrPostType.Answer, typeof(int), null, new CultureInfo("en-us", false)).Equals(3));
            //Assert.That(intToEnumConverter.Convert(TumblrPostType.Video, typeof(int), null, new CultureInfo("en-us", false)).Equals(4));
            //Assert.That(intToEnumConverter.Convert(TumblrPostType.Audio, typeof(int), null, new CultureInfo("en-us", false)).Equals(5));
            //Assert.That(intToEnumConverter.Convert(TumblrPostType.Photo, typeof(int), null, new CultureInfo("en-us", false)).Equals(6));
            //Assert.That(intToEnumConverter.Convert(TumblrPostType.Chat, typeof(int), null, new CultureInfo("en-us", false)).Equals(7));
        }
    }
}