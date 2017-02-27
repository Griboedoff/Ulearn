using System;
using log4net;

namespace uLearn
{
	public class FuncUtils
	{
		private static readonly ILog log = LogManager.GetLogger(typeof(FuncUtils));

		public static T TrySeveralTimes<T>(Func<T> func, int triesCount, Action runAfterFail, Type exceptionType)
		{
			for (var tryIndex = 0; tryIndex < triesCount; tryIndex++)
				try
				{
					return func.Invoke();
				}
				catch (Exception e) when (e.GetType().IsSubclassOf(exceptionType))
				{
					if (tryIndex >= triesCount - 1)
						throw;
					log.Warn($"Не удалось, попробую ещё раз (попытка {tryIndex + 2} из {triesCount})");
					runAfterFail.Invoke();
				}
			throw new Exception($"Can\'t run function {func} for {triesCount} times");
		}

		public static T TrySeveralTimes<T>(Func<T> func, int triesCount, Action runAfterFail)
		{
			return TrySeveralTimes(func, triesCount, runAfterFail, typeof(Exception));
		}

		public static T TrySeveralTimes<T>(Func<T> func, int triesCount, Type exceptionType)
		{
			return TrySeveralTimes(func, triesCount, () => { }, exceptionType);
		}

		public static T TrySeveralTimes<T>(Func<T> func, int triesCount)
		{
			return TrySeveralTimes(func, triesCount, () => { });
		}
	}
}