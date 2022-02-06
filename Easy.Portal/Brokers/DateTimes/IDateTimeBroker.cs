using System;
namespace Easy.Portal.Web.Brokers.DateTimes
{
	public interface IDateTimeBroker
	{
		DateTimeOffset GetCurrentDateTime();
	}
}

