// smidgens @ github

#if !EXT_0_UNITYENGINE_MONOBEHAVIOUR

namespace Smidgenomics.Unity.Extensions
{
	using UnityEngine;
	using System;
	using System.Collections;

	public static partial class MonoBehaviour_
	{
		/// <summary>
		/// Starts coroutine that lerps from 0-1 over time
		/// </summary>
		public static Coroutine Lerp01(this MonoBehaviour mb, float duration, Action<float> onStep, Action onDone = null)
		{
			return mb.StartCoroutine(LerpRoutine(duration, GetDefaultDeltaTime, onStep, onDone));
		}
		
		/// <summary>
		/// Starts coroutine that lerps from 0-1 over time
		/// </summary>
		public static Coroutine Lerp01(this MonoBehaviour mb, float duration, Func<float> deltaTimeFn, Action<float> onStep, Action onDone = null)
		{
			deltaTimeFn ??= GetDefaultDeltaTime;
			return mb.StartCoroutine(LerpRoutine(duration, deltaTimeFn, onStep, onDone));
		}

		private static float GetDefaultDeltaTime() => Time.deltaTime;

		private static IEnumerator LerpRoutine(float duration, Func<float> dtFn, Action<float> onStep, Action onDone)
		{
			if (onStep == null || Mathf.Approximately(duration, 0f) || duration < 0)
			{
				yield break;
			}

			float t = 0f;
			float elapsed = 0f;
			while (elapsed <= duration)
			{
				t = Mathf.Clamp01(elapsed / duration);
				onStep.Invoke(t);
				elapsed += dtFn.Invoke();
				yield return null;
			}
			if (!Mathf.Approximately(t, 1f))
			{
				onStep.Invoke(1f);
				yield return null;
			}
			onDone?.Invoke();
		}
	}
}

#endif