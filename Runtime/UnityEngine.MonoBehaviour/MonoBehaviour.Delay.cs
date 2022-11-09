// smidgens @ github

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;
	using System;
	using System.Collections;

	public static partial class MonoBehaviour_
	{
		/// <summary>
		/// Executes callback after given delay
		/// </summary>
		/// <param name="b">Behavior</param>
		/// <param name="delay">Delay (secs)</param>
		/// <param name="afterDelay">Callback</param>
		/// <returns>Coroutine</returns>
		public static Coroutine Delay(this MonoBehaviour b, in float delay, Action afterDelay)
		{
			return b.Delay(new WaitForSeconds(delay), afterDelay);
		}

		/// <summary>
		/// Executes callback after given 
		/// </summary>
		/// <param name="b">Behavior</param>
		/// <param name="delay">Delay (yield)</param>
		/// <param name="afterDelay">Callback</param>
		/// <returns>Coroutine</returns>
		/// <exception cref="ArgumentException"></exception>
		public static Coroutine Delay(this MonoBehaviour c, WaitForSeconds delay, Action afterDelay)
		{
			return c.StartCoroutine(DelayRoutine(delay, afterDelay));
		}

		// delay helper
		private static IEnumerator DelayRoutine(WaitForSeconds w, Action fn)
		{
			yield return w;
			fn.Invoke();
		}
	}
}