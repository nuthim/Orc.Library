using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orc.Library.Dictionaries;
using Orc.Library.Enums;
using Orc.Library.Messages.Client;

namespace Orc.Library.Tests.Messages.Client
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void TestCalendarDeleteMessage()
        {
            var actual = new CalendarDeleteMessage { Calendar = "AsxTrading" };
            var expected = new ClientMessageSerializer().Deserialize<CalendarDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCalendarDownloadMessage()
        {
            var actual = new CalendarDownloadMessage();
            var expected = new ClientMessageSerializer().Deserialize<CalendarDownloadMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCalendarEntriesDeleteMessage()
        {
            var actual = new CalendarEntriesDeleteMessage
            {
                Calendar = "AsxTrading",
                Entries = new CalendarEntries
                {
                    new CalendarEntry {Date = new DateTime(1980, 7, 28), RepeatMode = RepeatMode.Date },
                    new CalendarEntry {Date = new DateTime(1983, 6, 15), RepeatMode = RepeatMode.Yearly, Exclude = true }
                }
            };

            var expected = new ClientMessageSerializer().Deserialize<CalendarEntriesDeleteMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCalendarEntriesInsertMessage()
        {
            var actual = new CalendarEntriesInsertMessage
            {
                Calendar = "AsxTrading",
                Entries = new CalendarEntries
                {
                    new CalendarEntry {Date = new DateTime(1980, 7, 28), RepeatMode = RepeatMode.Date },
                    new CalendarEntry {Date = new DateTime(1983, 6, 15), RepeatMode = RepeatMode.Yearly, Exclude = true }
                }
            };

            var expected = new ClientMessageSerializer().Deserialize<CalendarEntriesInsertMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCalendarGetMessage()
        {
            var actual = new CalendarGetMessage { Calendar = "AsxTrading" };
            var expected = new ClientMessageSerializer().Deserialize<CalendarGetMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCalendarInsertMessage()
        {
            var actual = new CalendarInsertMessage { Calendar = "AsxTrading" };
            var expected = new ClientMessageSerializer().Deserialize<CalendarInsertMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCalendarSetDefaultMessage()
        {
            var actual = new CalendarSetDefaultMessage { Calendar = "AsxTrading" };
            var expected = new ClientMessageSerializer().Deserialize<CalendarSetDefaultMessage>();
            Assert.IsTrue(expected.Match(actual));
        }

        [TestMethod]
        public void TestCalendarUpdateMessage()
        {
            var actual = new CalendarUpdateMessage { Calendar = "AsxTrading", NewCalendar = "NewAsxTrading" };
            var expected = new ClientMessageSerializer().Deserialize<CalendarUpdateMessage>();
            Assert.IsTrue(expected.Match(actual));
        }
    }
}
