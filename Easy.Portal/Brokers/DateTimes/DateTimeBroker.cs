using System;
namespace Easy.Portal.Web.Brokers.DateTimes
{
	public class DateTimeBroker:IDateTimeBroker
	{


		public DateTimeOffset GetCurrentDateTime() =>
			DateTimeOffset.UtcNow;
    }
}

