using MyTestDateTime.Controllers;
using System;
using Xunit;

namespace MyTestDateTime.Test
{
    public class DateTimeControllerTest
    {

        [Fact]
        public void days_Should_Be_172800_For_2_Days_When_Pass_Second()
        {
            DateTimeController controller = new DateTimeController();
            var Seconds = controller.days(DateTimeOffset.Parse("2020-02-01"), DateTimeOffset.Parse("2020-02-03"), TimeFrame.Second);

            Assert.Equal(172800, Seconds);

        }

        [Fact]
        public void days_Should_Be_2880_For_2_Days_When_Pass_Minute()
        {
            DateTimeController controller = new DateTimeController();
            var Minutes = controller.days(DateTimeOffset.Parse("2020-02-01"), DateTimeOffset.Parse("2020-02-03"), TimeFrame.Minute);

            Assert.Equal(2880, Minutes);

        }

        [Fact]
        public void days_Should_Be_48_For_2_Days_When_Pass_Hour()
        {
            DateTimeController controller = new DateTimeController();
            var hours = controller.days(DateTimeOffset.Parse("2020-02-01"), DateTimeOffset.Parse("2020-02-03"), TimeFrame.Hour);

            Assert.Equal(48, hours);

        }

        [Fact]
        public void days_Should_Be_1_For_370_Days_When_Pass_year()
        {
            DateTimeController controller = new DateTimeController();
            var years = controller.days(DateTimeOffset.Parse("2019-02-01"), DateTimeOffset.Parse("2020-02-10"), TimeFrame.Year);

            Assert.Equal(1, years);

        }

        [Fact]
        public void days_Should_Be_2_For_2_Days_When_DoNot_Pass_TimeFrame()
        {
            DateTimeController controller = new DateTimeController();
            var days = controller.days(DateTimeOffset.Parse("2020-02-01"), DateTimeOffset.Parse("2020-02-03"));

            Assert.Equal(2, days);

        }

        [Fact]
        public void weekdays_Should_Be_5()
        {
            DateTimeController controller = new DateTimeController();
            var weekdays = controller.WeekDays(DateTimeOffset.Parse("2020-02-12"), DateTimeOffset.Parse("2020-02-19"));

            Assert.Equal(weekdays, 5);
        }

        [Fact]
        public void Should_Be_3_Complete_Week()
        {
            DateTimeController controller = new DateTimeController();
            var CompleteWeeks = controller.Weeks(DateTimeOffset.Parse("2020-01-29"), DateTimeOffset.Parse("2020-02-26"));

            Assert.Equal(CompleteWeeks, 3);
        }
    }
}
